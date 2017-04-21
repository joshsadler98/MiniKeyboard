namespace MyDialogs
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal class My_Dialogs
    {
        public static string InputBox(string promptText)
        {
            string str = "";
            return InputBox("", promptText, ref str);
        }

        public static string InputBox(string title, string promptText)
        {
            string str = "";
            return InputBox(title, promptText, ref str);
        }

        public static string InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox box = new TextBox();
            Button button = new Button();
            Button button2 = new Button();
            form.Text = title;
            label.Text = promptText;
            box.Text = value;
            button.Text = "OK";
            button2.Text = "Cancel";
            button.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
            label.SetBounds(9, 20, 0x174, 13);
            box.SetBounds(12, 0x24, 0x174, 20);
            button.SetBounds(0xe4, 0x48, 0x4b, 0x17);
            button2.SetBounds(0x135, 0x48, 0x4b, 0x17);
            label.AutoSize = true;
            box.Anchor |= AnchorStyles.Right;
            button.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            button2.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            form.ClientSize = new Size(0x18c, 0x6b);
            form.Controls.AddRange(new Control[] { label, box, button, button2 });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = button;
            form.CancelButton = button2;
            form.ShowDialog();
            return box.Text;
        }
    }
}

