namespace NotepadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ���θ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.Text = "";
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //����ڿ��� �� ������ ���� �ϰ���
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "�ؽ�Ʈ ����(*.txt)|*.txt|�������|*.*";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "")
            {
            }
            else
            {
                tbContents.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                this.Text = "�޸��� :" + openFileDialog1.FileName;
            }
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (saveFileDialog1.FileName == "")
                {
                    saveFileDialog1.Filter = "�ؽ�Ʈ ����(*.txt)|*.txt|�������|*.*";
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName == "")
                    {
                    }
                    else
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
                        //������ ����
                        saveFileDialog1.FileName = "";
                    }
                }
                else
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
                }
            }
        }

        private void �ٸ��̸���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "�ؽ�Ʈ ����(*.txt)|*.txt|�������|*.*";
            saveFileDialog1.ShowDialog();
            //����ڿ��� ������ ������ �����ϰ���
            if (saveFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
                saveFileDialog1.FileName = "";
            }
            //������ ����
            else
            {

            }

        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            //���α׷� ����
        }

        private void �ڵ��ٹٲ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.WordWrap = !tbContents.WordWrap;
        }

        private void �۲�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            tbContents.Font = fontDialog1.Font; 
        }

        private void ����ǥ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
        }

        private void �޸�������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            tbContents.BackColor = colorDialog1.Color;
        }

        private void tbContents_TextChanged(object sender, EventArgs e)
        {
            Line.Text = "�ټ� : " + tbContents.Lines.Length;
            Line2.Text = "�ܾ�� : " + tbContents.Text.Split(" ").Length;
        }
    }
}
