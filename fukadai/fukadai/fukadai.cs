using System;
using System.Windows.Forms;

class fukadai:Form
{
    private Label lb;
    private Button bt;
    public static void Main()
    {
        Application.Run(new fukadai());
    }
    public fukadai()
    {
        this.Text = "課題です。ボタン押すと文字が変わります。";
        this.Width = 250;this.Height = 100;

        lb = new Label();
        lb.Text = "ココが変わります";
        lb.Width = 150;
        bt = new Button();
        bt.Text = "ボタンちゃん";
        bt.Top = this.Top + lb.Height;
        bt.Width = lb.Width;
        bt.Parent = this;
        lb.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        lb.Text = "変わったよぉ～";
    }
}