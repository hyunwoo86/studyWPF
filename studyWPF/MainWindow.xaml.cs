using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace studyWPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point _startPoint;  // 시작 지점 저장
        private Line _currentLine;  // 현재 그리는 선
        private Polygon _arrowHead; // 현재 그리는 화살표 머리

        public MainWindow()
        {
            InitializeComponent();
        }

        // 마우스 버튼을 누르면 선 그리기 시작
        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // 시작 지점 저장
            _startPoint = e.GetPosition(DrawingCanvas);

            // 선 초기화
            _currentLine = new Line
            {
                X1 = _startPoint.X,
                Y1 = _startPoint.Y,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            // Canvas에 선 추가
            DrawingCanvas.Children.Add(_currentLine);
        }

        // 마우스를 움직일 때 실시간으로 선을 그림
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_currentLine != null && e.LeftButton == MouseButtonState.Pressed)
            {
                // 현재 마우스 위치를 끝점으로 설정
                Point currentPoint = e.GetPosition(DrawingCanvas);
                _currentLine.X2 = currentPoint.X;
                _currentLine.Y2 = currentPoint.Y;

                // 화살표 머리가 이미 그려진 상태면 제거
                if (_arrowHead != null)
                {
                    DrawingCanvas.Children.Remove(_arrowHead);
                }

                // 화살표 머리 계산 및 추가
                _arrowHead = new Polygon
                {
                    Fill = Brushes.Black,
                    Points = GetArrowHeadPoints(_startPoint.X, _startPoint.Y, currentPoint.X, currentPoint.Y, 10, 20)
                };
                DrawingCanvas.Children.Add(_arrowHead);
            }
        }

        // 마우스 버튼을 떼면 선 그리기를 완료
        private void Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _currentLine = null;  // 선 그리기 완료
            _arrowHead = null;    // 화살표 머리 그리기 완료
        }

        // 화살표 머리 모양을 계산하는 함수
        private PointCollection GetArrowHeadPoints(double startX, double startY, double endX, double endY, double arrowWidth, double arrowHeight)
        {
            Vector lineVector = new Vector(endX - startX, endY - startY);
            lineVector.Normalize();

            // 화살표 끝점에서 90도 회전 벡터 계산
            Vector normalVector = new Vector(-lineVector.Y, lineVector.X);

            // 화살표 끝점
            Point arrowTip = new Point(endX, endY);

            // 화살표 왼쪽과 오른쪽 포인트 계산
            Point leftPoint = arrowTip - lineVector * arrowHeight + normalVector * arrowWidth / 2;
            Point rightPoint = arrowTip - lineVector * arrowHeight - normalVector * arrowWidth / 2;

            // 삼각형 모양을 위한 PointCollection 반환
            return new PointCollection(new[] { arrowTip, leftPoint, rightPoint });
        }
    }
}
