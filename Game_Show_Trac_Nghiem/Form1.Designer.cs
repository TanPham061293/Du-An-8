namespace Game_Show_Trac_Nghiem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_Chaomung = new Label();
            lb_tracnghiem = new Label();
            bt_newgame = new Button();
            gb_Danhsach_cauhoi = new GroupBox();
            gb_Dapan = new GroupBox();
            gb_luachongoi_cauhoi = new GroupBox();
            rb_cauhoi_hacknao = new RadioButton();
            rb_cauhoi_vui = new RadioButton();
            ptb_anhDauGame = new PictureBox();
            lb_Cauhoi = new Label();
            bt_Next = new Button();
            bt_Thoatgame = new Button();
            gb_luachongoi_cauhoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_anhDauGame).BeginInit();
            SuspendLayout();
            // 
            // lb_Chaomung
            // 
            lb_Chaomung.AutoSize = true;
            lb_Chaomung.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Chaomung.Location = new Point(552, 58);
            lb_Chaomung.Name = "lb_Chaomung";
            lb_Chaomung.Size = new Size(236, 19);
            lb_Chaomung.TabIndex = 0;
            lb_Chaomung.Text = "Chào Mừng Bạn Đến Game Show";
           
            // 
            // lb_tracnghiem
            // 
            lb_tracnghiem.AutoSize = true;
            lb_tracnghiem.Location = new Point(272, 23);
            lb_tracnghiem.Name = "lb_tracnghiem";
            lb_tracnghiem.Size = new Size(168, 15);
            lb_tracnghiem.TabIndex = 1;
            lb_tracnghiem.Text = "Trắc Nghiệm Vui....ta.daaaaaaa";
            // 
            // bt_newgame
            // 
            bt_newgame.BackColor = Color.FromArgb(128, 255, 128);
            bt_newgame.Location = new Point(464, 15);
            bt_newgame.Name = "bt_newgame";
            bt_newgame.Size = new Size(95, 23);
            bt_newgame.TabIndex = 2;
            bt_newgame.Text = "New Game.";
            bt_newgame.UseVisualStyleBackColor = false;
            bt_newgame.Click += bt_newgame_Click;
            // 
            // gb_Danhsach_cauhoi
            // 
            gb_Danhsach_cauhoi.Location = new Point(12, 311);
            gb_Danhsach_cauhoi.Name = "gb_Danhsach_cauhoi";
            gb_Danhsach_cauhoi.Size = new Size(730, 100);
            gb_Danhsach_cauhoi.TabIndex = 3;
            gb_Danhsach_cauhoi.TabStop = false;
            gb_Danhsach_cauhoi.Text = "Danh sách câu hỏi:";
            // 
            // gb_Dapan
            // 
            gb_Dapan.Location = new Point(12, 139);
            gb_Dapan.Name = "gb_Dapan";
            gb_Dapan.Size = new Size(730, 152);
            gb_Dapan.TabIndex = 6;
            gb_Dapan.TabStop = false;
            // 
            // gb_luachongoi_cauhoi
            // 
            gb_luachongoi_cauhoi.Controls.Add(rb_cauhoi_hacknao);
            gb_luachongoi_cauhoi.Controls.Add(rb_cauhoi_vui);
            gb_luachongoi_cauhoi.Location = new Point(117, 44);
            gb_luachongoi_cauhoi.Name = "gb_luachongoi_cauhoi";
            gb_luachongoi_cauhoi.Size = new Size(225, 53);
            gb_luachongoi_cauhoi.TabIndex = 4;
            gb_luachongoi_cauhoi.TabStop = false;
            gb_luachongoi_cauhoi.Text = "Lựa chọn gói câu hỏi:";
            // 
            // rb_cauhoi_hacknao
            // 
            rb_cauhoi_hacknao.AutoSize = true;
            rb_cauhoi_hacknao.Location = new Point(175, 28);
            rb_cauhoi_hacknao.Name = "rb_cauhoi_hacknao";
            rb_cauhoi_hacknao.Size = new Size(121, 19);
            rb_cauhoi_hacknao.TabIndex = 5;
            rb_cauhoi_hacknao.TabStop = true;
            rb_cauhoi_hacknao.Text = "Câu hỏi HackNao.";
            rb_cauhoi_hacknao.UseVisualStyleBackColor = true;
            rb_cauhoi_hacknao.CheckedChanged += rb_cauhoi_hacknao_CheckedChanged;
            // 
            // rb_cauhoi_vui
            // 
            rb_cauhoi_vui.AutoSize = true;
            rb_cauhoi_vui.Location = new Point(19, 28);
            rb_cauhoi_vui.Name = "rb_cauhoi_vui";
            rb_cauhoi_vui.Size = new Size(89, 19);
            rb_cauhoi_vui.TabIndex = 6;
            rb_cauhoi_vui.TabStop = true;
            rb_cauhoi_vui.Text = "Câu hỏi Vui.";
            rb_cauhoi_vui.UseVisualStyleBackColor = true;
            rb_cauhoi_vui.CheckedChanged += rb_cauhoi_vui_CheckedChanged;
            // 
            // ptb_anhDauGame
            // 
            ptb_anhDauGame.BackColor = Color.FromArgb(255, 255, 192);
            ptb_anhDauGame.Location = new Point(12, 41);
            ptb_anhDauGame.Name = "ptb_anhDauGame";
            ptb_anhDauGame.Size = new Size(87, 50);
            ptb_anhDauGame.TabIndex = 5;
            ptb_anhDauGame.TabStop = false;
            // 
            // lb_Cauhoi
            // 
            lb_Cauhoi.Location = new Point(12, 100);
            lb_Cauhoi.Name = "lb_Cauhoi";
            lb_Cauhoi.Size = new Size(730, 53);
            lb_Cauhoi.TabIndex = 7;
            lb_Cauhoi.Text = "Câu hỏi";
            // 
            // bt_Next
            // 
            bt_Next.AllowDrop = true;
            bt_Next.BackColor = Color.FromArgb(128, 255, 128);
            bt_Next.Location = new Point(386, 58);
            bt_Next.Name = "bt_Next";
            bt_Next.Size = new Size(75, 23);
            bt_Next.TabIndex = 8;
            bt_Next.Text = "Câu tiếp.";
            bt_Next.UseVisualStyleBackColor = false;
            bt_Next.Click += bt_Next_Click;
            // 
            // bt_Thoatgame
            // 
            bt_Thoatgame.BackColor = Color.FromArgb(255, 128, 0);
            bt_Thoatgame.Location = new Point(70, 10);
            bt_Thoatgame.Name = "bt_Thoatgame";
            bt_Thoatgame.Size = new Size(94, 28);
            bt_Thoatgame.TabIndex = 9;
            bt_Thoatgame.Text = "Thoát Game.";
            bt_Thoatgame.UseVisualStyleBackColor = false;
            bt_Thoatgame.Click += bt_Thoatgame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_Thoatgame);
            Controls.Add(bt_Next);
            Controls.Add(lb_Cauhoi);
            Controls.Add(gb_Dapan);
            Controls.Add(ptb_anhDauGame);
            Controls.Add(gb_luachongoi_cauhoi);
            Controls.Add(gb_Danhsach_cauhoi);
            Controls.Add(bt_newgame);
            Controls.Add(lb_tracnghiem);
            Controls.Add(lb_Chaomung);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gb_luachongoi_cauhoi.ResumeLayout(false);
            gb_luachongoi_cauhoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_anhDauGame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Chaomung;
        private Label lb_tracnghiem;
        private Button bt_newgame;
        private GroupBox gb_Danhsach_cauhoi;
        private GroupBox gb_luachongoi_cauhoi;
        private RadioButton rb_cauhoi_hacknao;
        private RadioButton rb_cauhoi_vui;
        private PictureBox ptb_anhDauGame;
        private GroupBox gb_Dapan;
        private Label lb_Cauhoi;
        private Button bt_Next;
        private Button bt_Thoatgame;
    }
}