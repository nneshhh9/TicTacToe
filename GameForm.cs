using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_Нолики
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void TimerStop()
        {
            timer1.Stop();
            timer1.Enabled = false;
           
        }

        private void TimerStart()
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        List<Button> lsBtn=new List<Button>();


        /// <summary>
        /// Определение нажатой кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            logic.Move(lsBtn.IndexOf((Button)sender), lsBtn);
        }


        /// <summary>
        /// Начало новой игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            lsBtn.Clear();
            for (int i = 0; i < 9; i++)
            {
                Button button = new Button();
                button.Name = i.ToString();
                button.Text = " ";
                button.Click += Button_Click;
                button.Size = new Size(150,150);
                button.Enabled = false;
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
                button.UseVisualStyleBackColor = true;
                flowLayoutPanel1.Controls.Add(button);
                lsBtn.Add(button);
            }


            foreach (var item in lsBtn)
            {
                item.Text = " ";//обнуляем весь текст кнопок
                item.Enabled = true; //даем возможность отвечать кнопкой на действия пользователя
                item.BackColor = Color.Transparent;//задаем цвет фона, так как он у нас может быть красным после победы
            }
              logic = new LogicGame(Mode, lsBtn, Complexity); //создаем экземпляр игры
              logic.TimerStart += TimerStart;
              logic.TimerStop += TimerStop;
            if (Mode=="ПК-ПК")logic.StartAI();
        }

        LogicGame logic; //экземпляр игры
        string Mode= "Игрок-Игрок"; //поле хранящая значения режима
        string Complexity= "Нормально";

        /// <summary>
        /// Метод выбора режима игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Mode_Click(object sender, EventArgs e)
        {
            BtnP1_P2.Checked = false;
            BtnP1_CPU.Checked = false;
            BtnCPU_P1.Checked = false;
            BtnCPU1_CPU2.Checked = false;
            ToolStripMenuItem menuStrip = (ToolStripMenuItem)sender;
            menuStrip.Checked = true;
            Mode=sender.ToString();
        }


        /// <summary>
        /// Метод выбора сложности игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Сomplexity_Click(object sender, EventArgs e)
        {
            btnNormal.Checked = false;
            btnHard.Checked = false;
            ToolStripMenuItem menuStrip = (ToolStripMenuItem)sender;
            menuStrip.Checked = true;
            Complexity= sender.ToString();
        }

        //цикл для игры Пк-Пк
        private void Timer1_Tick(object sender, EventArgs e)
        {
            logic.CPUMove();
        }
    }
}
