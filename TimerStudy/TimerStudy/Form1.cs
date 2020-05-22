using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerStudy
{
    public partial class Form1 : Form
    {
        //TimerBlock timer = new TimerBlock();

        int id = 0;
        List<TimerBlock> listTimer = new  List<TimerBlock>();
        public Button plusButton = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            timerForm.Start();
            //  timer.TimerBlockLoad();
            //  Controls.Add(timer.labelName);
            //  Controls.Add(timer.labelHour);
            //  Controls.Add(timer.labelMinute);
            //   Controls.Add(timer.labelSecond);
            //  Controls.Add(timer.playbutton);
            //   Controls.Add(timer.block);
            plusButton.Location = new System.Drawing.Point(123, 20);
            plusButton.Size = new System.Drawing.Size(32, 32);
            plusButton.FlatStyle = FlatStyle.Flat;
            Controls.Add(plusButton);
           // plusButton.Click += plusButton_Click;






        }

        private void timerForm_Tick(object sender, EventArgs e)
        {
            foreach (TimerBlock b in listTimer)
            {
                b.PlayTimer();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using(TimerContext db = new TimerContext())
            {
              //  TImerTabl t = new TImerTabl { Name = timer.name, Hour = timer.hour, Minute = timer.minute, Second = timer.second };
              //  if (db.TimerTabls == 0)
                {
              //      db.TimerTabls.Add(t);
              //      db.SaveChanges();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id++;
            plusButton.Location = new Point(123,id*85);
            TimerBlock tim = new TimerBlock();
            tim.id = id;
            tim.TimerBlockLoad();
            Controls.Add(tim.labelName);
            Controls.Add(tim.labelHour);
            Controls.Add(tim.labelMinute);
            Controls.Add(tim.labelSecond);
            Controls.Add(tim.playbutton);
            Controls.Add(tim.block);
            listTimer.Add(tim);
            //foreach(TimerBlock b in listTimer)
           // {

              
           // }
        }
    }
}
