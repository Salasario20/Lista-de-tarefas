using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

       public List<string> tasksToDoList = new List<string>(){"Carlos", "Ana", "Joao"};
        public void RefreshFlowLayoutPanel1(){
            flowLayoutPanel1.Controls.Clear();
        }
        public void ShowTasks()
        {
            for (int i = 0; i < tasksToDoList.Count; i++)
            {
                Label taskLabel = new Label();
                Button buttonDeleteTask = new Button();

                taskLabel.Text = tasksToDoList[i];
                taskLabel.AutoSize = true;
                taskLabel.Font = new Font("Arial", 12, FontStyle.Regular);

                buttonDeleteTask.Text = "X";
                buttonDeleteTask.Tag = tasksToDoList[i];
                buttonDeleteTask.Click += ButtonDeleteTask_Click;
                flowLayoutPanel1.SetFlowBreak(buttonDeleteTask, true);
                flowLayoutPanel1.Controls.Add(taskLabel);
                flowLayoutPanel1.Controls.Add(buttonDeleteTask);
               
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTaks_Click(object sender, EventArgs e)
        {
          int inputTxtLength = textBox1.Text.Length;
            if(inputTxtLength >= 1) { 
            tasksToDoList.Add(textBox1.Text);
            RefreshFlowLayoutPanel1();
            ShowTasks();
            textBox1.Text = "";
            }
        }

        private void lblTest_Click(object sender, EventArgs e)

        {
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTasks();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        
        }
        private void ButtonDeleteTask_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string taskToRemove = (string)button.Tag;
            tasksToDoList.Remove(taskToRemove);
            RefreshFlowLayoutPanel1();
            ShowTasks();
            
        }
    }
}
