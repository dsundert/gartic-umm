using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;


namespace GarticUmm
{
    public partial class GUGameForm : MetroForm
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        private DrawLineHistroy history = new DrawLineHistroy();

        public GUGameForm()
        {
            InitializeComponent();
            g = panel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 그림판 초기 상태: 펜굵기 제일 얇음, 펜 색상 검정, 얇은 펜, 검은색 버튼 눌린 상태
            pen = new Pen(Color.Black, 5);
            this.thinbtn.Pushed = true;
            this.blackbtn.Pushed = true;

            // For develop - Woong
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Text (*.txt)|*.txt";
            saveFileDialog1.Filter = "Text (*.txt)|*.txt";
            saveFileDialog1.FileName = "*.txt";
        }

        private void GUGameForm_Load(object sender, EventArgs e)
        {
            UpdateCountdown(); // 타이머설정 및 타이머 따라 상태 변화
        }
        
        private void UpdateCountdown()
        {
            int count = 10; // 최초 실행시 그림 확인 시간 10초로 초기화
            int[] times = { 10, 3, 30 }; // 한 천에 사용되는 시간들, 최초 확인시간 10초, 그릴 준비 3초, 그리는 시간 30초
            int index = 0;
            Timer timer = new Timer();
            timer.Interval = 1000; // 1초마다 실행
            timer.Tick += (s, e) =>
            {
                count--; // 카운트 다운 시작
                if (count < 0)
                {
                    index++; // 최초 10초가 다 지나면 배열 인덱스 증가
                    if (index >= times.Length) // 턴이 모두 실행 됐을 때
                    {
                        timer.Stop(); // 타이머 동작 중지 후 턴 종료 메세지 박스
                        MessageBox.Show("Turn End");
                        return;
                    }

                    switch(index)
                    {
                        case 0: // 최초 상태
                            LabelStatus.Text = " ";
                            break;
                        case 1: // 준비 단계
                            LabelStatus.Text = "Ready...";
                            break;
                        case 2: // 그리는 단계
                            LabelStatus.Text = "Drawing...";
                            break;
                    }

                    count = times[index]; // 다음 시간 대입
                }

                LabelTimer.Text = count.ToString();
            };
            timer.Start();
        }

        private void AddDrawingHistory(Pen pen, Point pointFrom, Point pointDest)
        {
            history.addHistory(pen, pointFrom, pointDest);
        }

        private void ClearDrawingHistory()
        {
            history.clearHistory();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && moving && x != -1 && y != -1)
            {
                AddDrawingHistory(pen, new Point(x, y), e.Location);
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        // For develop - Woong
        private void menuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ClearDrawingHistory();

                // load
                Stream stream = openFileDialog1.OpenFile();
                StreamReader sr = new StreamReader(stream);
                string csv = sr.ReadToEnd();
                sr.Close();
                stream.Close();
                // deserialize drawing history
                history.loadHistory(DrawLineHistroy.toList(csv));
                // drawing
                foreach (var line in history.getHistory())
                {
                    Pen penHistory = new Pen(line.getColor(), line.getWidth());
                    g.DrawLine(penHistory, new Point(line.FromX, line.FromY), new Point(line.DestX, line.DestY));
                }
            }
        }
        // For develop - Woong
        private void menuSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // serialize drawing history
                string csv = history.toCSVString();
                // save
                Stream stream = saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(stream);
                sw.Write(csv);
                sw.Close();
                stream.Close();
            }
        }

        private void toolBar2_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == thinbtn)
            {
                this.thinbtn.Pushed = true;
                this.middlebtn.Pushed = false;
                this.thickbtn.Pushed = false;

                pen.Width = 5;
            }
            if (e.Button == middlebtn)
            {
                this.thinbtn.Pushed = false;
                this.middlebtn.Pushed = true;
                this.thickbtn.Pushed = false;

                pen.Width = 10;
            }
            if (e.Button == thickbtn)
            {
                this.thinbtn.Pushed = false;
                this.middlebtn.Pushed = false;
                this.thickbtn.Pushed = true;

                pen.Width = 30;
            }
            if(e.Button == eraserbtn)
            {
                Set_initial();
                panel.Refresh();
                ClearDrawingHistory();
            }
            
            if (e.Button == redbtn)
            {
                this.redbtn.Pushed = true;
                this.greenbtn.Pushed = false;
                this.bluebtn.Pushed = false;
                this.yellowbtn.Pushed = false;
                this.purplebtn.Pushed = false;
                this.blackbtn.Pushed = false;

                pen.Color = Color.Red;
            }
            else if (e.Button == yellowbtn)
            {
                this.redbtn.Pushed = false;
                this.greenbtn.Pushed = false;
                this.bluebtn.Pushed = false;
                this.yellowbtn.Pushed = true;
                this.purplebtn.Pushed = false;
                this.blackbtn.Pushed = false;

                pen.Color = Color.Yellow;
            }
            else if (e.Button == greenbtn)
            {
                this.redbtn.Pushed = false;
                this.greenbtn.Pushed = true;
                this.bluebtn.Pushed = false;
                this.yellowbtn.Pushed = false;
                this.purplebtn.Pushed = false;
                this.blackbtn.Pushed = false;

                pen.Color = Color.Green;
            }
            else if (e.Button == bluebtn)
            {
                this.redbtn.Pushed = false;
                this.greenbtn.Pushed = false;
                this.bluebtn.Pushed = true;
                this.yellowbtn.Pushed = false;
                this.purplebtn.Pushed = false;
                this.blackbtn.Pushed = false;

                pen.Color = Color.Blue;
            }
            else if (e.Button == purplebtn)
            {
                this.redbtn.Pushed = false;
                this.greenbtn.Pushed = false;
                this.bluebtn.Pushed = false;
                this.yellowbtn.Pushed = false;
                this.purplebtn.Pushed = true;
                this.blackbtn.Pushed = false;

                pen.Color = Color.Purple;
            }
            else if (e.Button == blackbtn)
            {
                this.redbtn.Pushed = false;
                this.greenbtn.Pushed = false;
                this.bluebtn.Pushed = false;
                this.yellowbtn.Pushed = false;
                this.purplebtn.Pushed = false;
                this.blackbtn.Pushed = true;

                pen.Color = Color.Black;
            }
        }
            
        private void Set_initial()
        {
            this.thinbtn.Pushed = true;
            this.middlebtn.Pushed = false;
            this.thickbtn.Pushed = false;
            this.redbtn.Pushed = false;
            this.yellowbtn.Pushed = false;
            this.greenbtn.Pushed = false;
            this.bluebtn.Pushed = false;
            this.purplebtn.Pushed = false;
            this.blackbtn.Pushed = true;

            pen.Width = 5;
            pen.Color = Color.Black;
        }
    }
}