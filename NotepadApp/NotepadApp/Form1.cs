namespace NotepadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.Text = "";
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            //사용자에게 열 파일을 선택 하게함
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "")
            {
            }
            else
            {
                tbContents.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                this.Text = "메모장 :" + openFileDialog1.FileName;
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (saveFileDialog1.FileName == "")
                {
                    saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName == "")
                    {
                    }
                    else
                    {
                    //파일을 저장
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
                        saveFileDialog1.FileName = "";
                    }
                }
                else
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
                }
            }
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            saveFileDialog1.ShowDialog();
            //사용자에게 저장할 파일을 선택하게함
            if (saveFileDialog1.FileName != "")
            {
            //파일을 저장
                System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
                saveFileDialog1.FileName = "";
            }
            else
            {

            }

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            //프로그램 종료
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.WordWrap = !tbContents.WordWrap;
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            tbContents.Font = fontDialog1.Font; 
        }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            tbContents.BackColor = colorDialog1.Color;
        }

        private void tbContents_TextChanged(object sender, EventArgs e)
        {
            Line.Text = "줄수 : " + tbContents.Lines.Length;
            Line2.Text = "단어수 : " + tbContents.Text.Split(" ").Length;
        }
    }
}
