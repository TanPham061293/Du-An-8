using System.Diagnostics.Eventing.Reader;

namespace Game_Show_Trac_Nghiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Dia_chi_Cau_Cau_Hoi_Vui = "Danh_Sach_Cau_Hoi_Vui.txt";
        string Dia_chi_Cau_Cau_Hoi_HackNao = "Danh_Sach_Cau_Hoi_HackNao.txt";
        List<string> Danh_Sach_Cau_Hoi = new List<string>();
        string Dia_Chi_Dap_An_Vui = "Dap_An_Cau_Hoi_Vui.txt";
        string Dia_Chi_Dap_An_HackNao = "Dap_An_Cau_Hoi_HackNao.txt";
        List<string> arr_Dapan_Vui = new List<string>();
        List<RadioButton> arr_gb_Cauhoi = new List<RadioButton>();
        List<string> abc = new List<string>(); // danh sách lựa con abc theo từng câu
        List<List<string>> Danh_Sach_Dap_An_Theo_Cau = new List<List<string>>(); // danh sách chưa abc theo câu
        List<RadioButton> arr_rb = new List<RadioButton>(); // danh sách chưa mảng radiobutton
        int Index = 0; // chỉ số theo câu hỏi tương ứng 
        int ChiSo_xetDKLocation = 0; // để xét dk location các radiobutton
        int ChiSo_xetDKLocation2 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            ptb_anhDauGame.Visible = false; // ẩn các control chưa dùng đến
            gb_luachongoi_cauhoi.Visible = false;
            lb_Cauhoi.Visible = false;
            gb_Dapan.Visible = false;
            gb_Danhsach_cauhoi.Visible = false;

            bt_Next.Visible = false;
            bt_Thoatgame.Visible = false;
            //this.BackgroundImage = Image.FromFile("C:\\Users\\PC\\Desktop\\Anh_BackGroud\\1.jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            lb_Chaomung.Location = new Point(255, 115);
            lb_Chaomung.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);

            lb_tracnghiem.Location = new Point(lb_Chaomung.Location.X + (lb_Chaomung.Size.Width) / 2 - (lb_tracnghiem.Size.Width) / 2, 180);
            lb_tracnghiem.Font = new Font("Times New Roman", 15F, FontStyle.Italic, GraphicsUnit.Point);

            bt_newgame.Location = new Point(lb_tracnghiem.Location.X + (lb_tracnghiem.Size.Width) / 2 - (bt_newgame.Size.Width) / 2, 246);
            bt_newgame.Font = new Font("VNI-Ariston", 12F, FontStyle.Underline, GraphicsUnit.Point);
            bt_newgame.AutoSize = true;
            if (!File.Exists(Dia_chi_Cau_Cau_Hoi_Vui) || !File.Exists(Dia_Chi_Dap_An_Vui)) // kiểm tra địa chỉ file
            {
                MessageBox.Show("Địa chỉ File không chính xác.");
            }
        }

        private void bt_newgame_Click(object sender, EventArgs e)
        {
            lb_Chaomung.Visible = false;
            lb_tracnghiem.Visible = false;
            bt_newgame.Visible = false;

            ptb_anhDauGame.Visible = true;
            ptb_anhDauGame.Location = new Point(185, 44);
            ptb_anhDauGame.Size = new Size(359, 245);
            ptb_anhDauGame.BackgroundImage = Image.FromFile("Anh_BackGroud\\3.jpg");
            ptb_anhDauGame.BackgroundImageLayout = ImageLayout.Stretch;

            gb_luachongoi_cauhoi.Visible = true;
            gb_luachongoi_cauhoi.Location = new Point(185, 317);
            gb_luachongoi_cauhoi.Size = new Size(359, 53);
        }
        void Hanhdongkhicheck_true()
        {
            if (rb_cauhoi_vui.Checked == true)
            {
                DialogResult luachon = MessageBox.Show("Bạn đã chắc lựa chọn gói câu hỏi vui.", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (luachon == DialogResult.Yes)
                {
                    ptb_anhDauGame.Visible = false;
                    gb_luachongoi_cauhoi.Visible = false;

                    lb_Cauhoi.Visible = true;
                    lb_Cauhoi.Location = new Point(154, 100);
                    lb_Cauhoi.Text = Danh_Sach_Cau_Hoi[Index].ToString();
                    TaoRadioButton();

                    gb_Dapan.Visible = true;
                    gb_Dapan.Location = new Point(154, 100 + lb_Cauhoi.Size.Height + 20);
                    gb_Dapan.BackgroundImage = Image.FromFile("Anh_BackGroud\\2.jpg");

                    bt_Thoatgame.Visible = true;
                    bt_Next.Location = new Point(lb_Cauhoi.Location.X + lb_Cauhoi.Size.Width - 50, 10);
                    bt_Next.Font = new Font("VNI-Ariston", 12F, FontStyle.Underline, GraphicsUnit.Point);
                    bt_Next.AutoSize = true;
                    bt_Next.Visible = true;


                    for (int i = 0; i < Danh_Sach_Cau_Hoi.Count; i++)
                    {
                        RadioButton rb1 = new RadioButton();
                        rb1.Text = "Câu: " + (i + 1).ToString();
                        rb1.AutoSize = true;
                        rb1.BackColor = Color.Beige;
                        rb1.Enabled = false;

                        if (i == 0)
                        {
                            rb1.Location = new Point(5, 20);

                        }
                        else if (i == 1)
                        {
                            rb1.Location = new Point(5, 40);
                        }

                        else
                        {
                            rb1.Location = new Point(arr_gb_Cauhoi[arr_gb_Cauhoi.Count - 2].Location.X + 10 + (arr_gb_Cauhoi[arr_gb_Cauhoi.Count - 2].Size.Width), arr_gb_Cauhoi[arr_gb_Cauhoi.Count - 2].Location.Y);

                        }
                        ChiSo_xetDKLocation2++;
                        arr_gb_Cauhoi.Add(rb1);
                        this.gb_Danhsach_cauhoi.Controls.Add(rb1);
                    }
                    arr_gb_Cauhoi[Index].BackColor = Color.LightPink;
                    gb_Danhsach_cauhoi.Visible = true;
                    gb_Danhsach_cauhoi.AutoSize = true;
                    gb_Danhsach_cauhoi.Location = new Point(gb_Dapan.Location.X, gb_Dapan.Location.Y + gb_Dapan.Size.Height + 20);
                }
            }
            if (rb_cauhoi_hacknao.Checked == true)
            {
                DialogResult luachon = MessageBox.Show("Bạn đã chắc lựa chọn gói câu hỏi HackNao.", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (luachon == DialogResult.Yes)
                {
                    ptb_anhDauGame.Visible = false;
                    gb_luachongoi_cauhoi.Visible = false;

                    lb_Cauhoi.Visible = true;
                    lb_Cauhoi.Location = new Point(154, 100);
                    lb_Cauhoi.Text = Danh_Sach_Cau_Hoi[Index].ToString();
                    TaoRadioButton();

                    gb_Dapan.Visible = true;
                    gb_Dapan.Location = new Point(154, 100 + lb_Cauhoi.Size.Height + 20);
                    gb_Dapan.BackgroundImage = Image.FromFile("Anh_BackGroud\\1.jpg");

                    bt_Thoatgame.Visible = true;
                    bt_Next.Location = new Point(lb_Cauhoi.Location.X + lb_Cauhoi.Size.Width - 50, 10);
                    bt_Next.Font = new Font("Times New Roman", 12F, FontStyle.Underline, GraphicsUnit.Point);
                    bt_Next.AutoSize = true;
                    bt_Next.Visible = true;


                    for (int i = 0; i < Danh_Sach_Cau_Hoi.Count; i++)
                    {
                        RadioButton rb1 = new RadioButton();
                        rb1.Text = "Câu: " + (i + 1).ToString();
                        rb1.AutoSize = true;
                        rb1.BackColor = Color.Beige;
                        rb1.Enabled = false;

                        if (i == 0)
                        {
                            rb1.Location = new Point(5, 20);

                        }
                        else if (i == 1)
                        {
                            rb1.Location = new Point(5, 40);
                        }

                        else
                        {
                            rb1.Location = new Point(arr_gb_Cauhoi[arr_gb_Cauhoi.Count - 2].Location.X + 10 + (arr_gb_Cauhoi[arr_gb_Cauhoi.Count - 2].Size.Width), arr_gb_Cauhoi[arr_gb_Cauhoi.Count - 2].Location.Y);
                        }
                        arr_gb_Cauhoi.Add(rb1);
                        this.gb_Danhsach_cauhoi.Controls.Add(rb1);
                    }
                    arr_gb_Cauhoi[Index].BackColor = Color.LightPink;
                    gb_Danhsach_cauhoi.Visible = true;
                    gb_Danhsach_cauhoi.AutoSize = true;
                    gb_Danhsach_cauhoi.Location = new Point(gb_Dapan.Location.X, gb_Dapan.Location.Y + gb_Dapan.Size.Height + 20);
                }
            }
        }
        private void rb_cauhoi_vui_CheckedChanged(object sender, EventArgs e)
        {
            bt_Next.Enabled = false;
            Danh_Sach_Cau_Hoi.Clear();
            Danh_Sach_Dap_An_Theo_Cau.Clear();
            arr_rb.Clear();
            gb_Dapan.Controls.Clear();
            ChiSo_xetDKLocation = 0;
            Index = 0;
            if (rb_cauhoi_vui.Checked == true)
            {
                foreach (var item in File.ReadLines(Dia_chi_Cau_Cau_Hoi_Vui)) // đọc câu hỏi từ file
                {
                    if (item.Contains("A.") || item.Contains("B.") || item.Contains("C.") || item.Contains("D."))
                    {
                        abc.Add(item); // đưa ựa chọn vào abc
                    }
                    else if (item != "")
                    {
                        Danh_Sach_Cau_Hoi.Add(item); // đưa câu hỏi vào danh sách
                        if (abc.Count != 0)
                        {
                            // cần tạo thêm 1 mảng gán bằng abc và thêm vào danh sách đáp án theo câu. nếu không kho clear abc thì danh sách đáp án theo câu sẻ bị rỗng
                            Danh_Sach_Dap_An_Theo_Cau.Add(new List<String>(abc));// không dduocj thêm trực tiếp abc
                            abc.Clear();
                        }
                    }
                }
                if (Danh_Sach_Cau_Hoi.Count != Danh_Sach_Dap_An_Theo_Cau.Count)// đưa các lựa chọn câu hỏi cuối cùng vào
                {
                    Danh_Sach_Dap_An_Theo_Cau.Add(new List<String>(abc));
                    abc.Clear();
                }

                foreach (var item3 in File.ReadAllLines(Dia_Chi_Dap_An_Vui)) // đưa đáp án vào mảng từ file
                {
                    arr_Dapan_Vui.Add(item3);
                }
                Hanhdongkhicheck_true();
            }
        }
        void TaoRadioButton()
        {
            foreach (var item in Danh_Sach_Dap_An_Theo_Cau[Index])
            {
                RadioButton rb = new RadioButton();
                rb.Text = item;
                rb.AutoSize = true;
                rb.BackColor = Color.DarkKhaki;
                if (ChiSo_xetDKLocation != 0)
                {
                    rb.Location = new Point(arr_rb[arr_rb.Count - 1].Location.X, arr_rb[arr_rb.Count - 1].Location.Y + 10 + (arr_rb[arr_rb.Count - 1].Size.Height));
                }
                ChiSo_xetDKLocation++;
                rb.Click += Rb_Click;
                arr_rb.Add(rb);
                this.gb_Dapan.Controls.Add(rb);
            }
        }

        private void Rb_Click(object? sender, EventArgs e)
        {
            TrangthaiCheck();
        }

        void TrangthaiCheck()
        {
            foreach (var item in arr_rb)
            {
                if (item.Checked == true)
                {
                    DialogResult luachon = MessageBox.Show("Đáp án của bạn la:" + item.Text, "Thông báo.", MessageBoxButtons.YesNo);
                    if (luachon == DialogResult.Yes)
                    {
                        int ChiSo_dauCach = item.Text.IndexOf(" ");
                        string str = item.Text.Substring(ChiSo_dauCach + 1);
                        bool check = false;
                        foreach (var item1 in arr_Dapan_Vui)
                        {
                            if (str.CompareTo(item1) == 0)
                            {
                                if (Index != Danh_Sach_Cau_Hoi.Count - 1)
                                {
                                    DialogResult luachon2 = MessageBox.Show("Bạn đã trả lời chính xác.");

                                    bt_Next.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Bạn đã trả lời chính xác.");
                                    MessageBox.Show("Bạn Đã Giành Chiến Thắng.");
                                    lb_Cauhoi.Visible = false;
                                    gb_Dapan.Visible = false;
                                    bt_Thoatgame.Visible = true;
                                    bt_Next.Visible = true;

                                    ptb_anhDauGame.Visible = true;
                                    gb_luachongoi_cauhoi.Visible = true;
                                    gb_Danhsach_cauhoi.Visible = false;

                                }
                                check = true;
                                break;
                            }
                        }
                        if (check == false)
                        {
                            MessageBox.Show("Lụa chọn không chính xác.");
                        }
                    }
                }
            }
        }
        private void bt_Next_Click(object sender, EventArgs e)
        {
            Index++;
            lb_Cauhoi.Text = Danh_Sach_Cau_Hoi[Index]; // đang sử dụng dialogresulf.ok
            ChiSo_xetDKLocation = 0;
            arr_rb.Clear();
            gb_Dapan.Controls.Clear();
            bt_Next.Enabled = false;

            TaoRadioButton();

            arr_gb_Cauhoi[Index - 1].Enabled = true;
            arr_gb_Cauhoi[Index - 1].BackColor = Color.Green;
            arr_gb_Cauhoi[Index].BackColor = Color.LightPink;
        }

        private void rb_cauhoi_hacknao_CheckedChanged(object sender, EventArgs e)
        {
            bt_Next.Enabled = false;
            Danh_Sach_Cau_Hoi.Clear();
            Danh_Sach_Dap_An_Theo_Cau.Clear();
            arr_rb.Clear();
            gb_Dapan.Controls.Clear();
            ChiSo_xetDKLocation = 0;
            Index = 0;

            if (rb_cauhoi_hacknao.Checked == true)
            {
                foreach (var item in File.ReadLines(Dia_chi_Cau_Cau_Hoi_HackNao)) // đọc câu hỏi từ file
                {
                    if (item.Contains("A.") || item.Contains("B.") || item.Contains("C.") || item.Contains("D."))
                    {
                        abc.Add(item); // đưa ựa chọn vào abc
                    }
                    else if (item != "")
                    {
                        Danh_Sach_Cau_Hoi.Add(item); // đưa câu hỏi vào danh sách
                        if (abc.Count != 0)
                        {
                            // cần tạo thêm 1 mảng gán bằng abc và thêm vào danh sách đáp án theo câu. nếu không kho clear abc thì danh sách đáp án theo câu sẻ bị rỗng
                            Danh_Sach_Dap_An_Theo_Cau.Add(new List<String>(abc));// không dduocj thêm trực tiếp abc
                            abc.Clear();
                        }
                    }
                }
                if (Danh_Sach_Cau_Hoi.Count != Danh_Sach_Dap_An_Theo_Cau.Count)// đưa các lựa chọn câu hỏi cuối cùng vào
                {
                    Danh_Sach_Dap_An_Theo_Cau.Add(new List<String>(abc));
                    abc.Clear();
                }

                foreach (var item3 in File.ReadAllLines(Dia_Chi_Dap_An_HackNao)) // đưa đáp án vào mảng từ file
                {
                    arr_Dapan_Vui.Add(item3);
                }
                Hanhdongkhicheck_true();
            }
        }

        private void bt_Thoatgame_Click(object sender, EventArgs e)
        {
            lb_Cauhoi.Visible = false;
            gb_Dapan.Visible = false;
            bt_Thoatgame.Visible = false;
            bt_Next.Visible = false;
            ptb_anhDauGame.Visible = true;
            gb_luachongoi_cauhoi.Visible = true;
            Danh_Sach_Cau_Hoi.Clear();
            Danh_Sach_Dap_An_Theo_Cau.Clear();
            arr_rb.Clear();
            gb_Dapan.Controls.Clear();
            ChiSo_xetDKLocation = 0;
            Index = 0;
            arr_gb_Cauhoi.Clear();
            ChiSo_xetDKLocation2 = 0;
            this.gb_Danhsach_cauhoi.Controls.Clear();
            gb_Danhsach_cauhoi.Visible = false;
        }        
    }
}