
namespace Крестики_Нолики
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnStartGame = new System.Windows.Forms.ToolStripMenuItem();
            this.пппToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnP1_P2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnP1_CPU = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCPU_P1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCPU1_CPU2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ппToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHard = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(470, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnStartGame,
            this.пппToolStripMenuItem,
            this.ппToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(89, 21);
            this.BtnStartGame.Text = "Новая игра";
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // пппToolStripMenuItem
            // 
            this.пппToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnP1_P2,
            this.BtnP1_CPU,
            this.BtnCPU_P1,
            this.BtnCPU1_CPU2});
            this.пппToolStripMenuItem.Name = "пппToolStripMenuItem";
            this.пппToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.пппToolStripMenuItem.Text = "Режим игры";
            // 
            // BtnP1_P2
            // 
            this.BtnP1_P2.Checked = true;
            this.BtnP1_P2.CheckOnClick = true;
            this.BtnP1_P2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BtnP1_P2.Name = "BtnP1_P2";
            this.BtnP1_P2.Size = new System.Drawing.Size(155, 22);
            this.BtnP1_P2.Text = "Игрок-Игрок";
            this.BtnP1_P2.Click += new System.EventHandler(this.Btn_Mode_Click);
            // 
            // BtnP1_CPU
            // 
            this.BtnP1_CPU.CheckOnClick = true;
            this.BtnP1_CPU.Name = "BtnP1_CPU";
            this.BtnP1_CPU.Size = new System.Drawing.Size(155, 22);
            this.BtnP1_CPU.Text = "Игрок-ПК";
            this.BtnP1_CPU.Click += new System.EventHandler(this.Btn_Mode_Click);
            // 
            // BtnCPU_P1
            // 
            this.BtnCPU_P1.CheckOnClick = true;
            this.BtnCPU_P1.Name = "BtnCPU_P1";
            this.BtnCPU_P1.Size = new System.Drawing.Size(155, 22);
            this.BtnCPU_P1.Text = "ПК-Игрок";
            this.BtnCPU_P1.Click += new System.EventHandler(this.Btn_Mode_Click);
            // 
            // BtnCPU1_CPU2
            // 
            this.BtnCPU1_CPU2.CheckOnClick = true;
            this.BtnCPU1_CPU2.Name = "BtnCPU1_CPU2";
            this.BtnCPU1_CPU2.Size = new System.Drawing.Size(155, 22);
            this.BtnCPU1_CPU2.Text = "ПК-ПК";
            this.BtnCPU1_CPU2.Click += new System.EventHandler(this.Btn_Mode_Click);
            // 
            // ппToolStripMenuItem
            // 
            this.ппToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNormal,
            this.btnHard});
            this.ппToolStripMenuItem.Name = "ппToolStripMenuItem";
            this.ппToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.ппToolStripMenuItem.Text = "Сложность";
            // 
            // btnNormal
            // 
            this.btnNormal.Checked = true;
            this.btnNormal.CheckOnClick = true;
            this.btnNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(146, 22);
            this.btnNormal.Text = "Нормально";
            this.btnNormal.Click += new System.EventHandler(this.Btn_Сomplexity_Click);
            // 
            // btnHard
            // 
            this.btnHard.CheckOnClick = true;
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(146, 22);
            this.btnHard.Text = "Сложно";
            this.btnHard.Click += new System.EventHandler(this.Btn_Сomplexity_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 474);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(470, 521);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра Крестики-Нолики";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnStartGame;
        private System.Windows.Forms.ToolStripMenuItem пппToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnP1_P2;
        private System.Windows.Forms.ToolStripMenuItem BtnP1_CPU;
        private System.Windows.Forms.ToolStripMenuItem BtnCPU_P1;
        private System.Windows.Forms.ToolStripMenuItem BtnCPU1_CPU2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ппToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNormal;
        private System.Windows.Forms.ToolStripMenuItem btnHard;
    }
}

