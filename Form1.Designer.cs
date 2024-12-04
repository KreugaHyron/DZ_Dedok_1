namespace DZ_Dedok_1
{
    partial class MainForm
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
            listBox1 = new ListBox();
            buttonAddTask = new Button();
            buttonCompleteTask = new Button();
            textBox1 = new TextBox();
            buttonDeleteTask = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(12, 182);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(75, 23);
            buttonAddTask.TabIndex = 1;
            buttonAddTask.Text = "Add";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // buttonCompleteTask
            // 
            buttonCompleteTask.Location = new Point(12, 225);
            buttonCompleteTask.Name = "buttonCompleteTask";
            buttonCompleteTask.Size = new Size(75, 23);
            buttonCompleteTask.TabIndex = 2;
            buttonCompleteTask.Text = "Complete";
            buttonCompleteTask.UseVisualStyleBackColor = true;
            buttonCompleteTask.Click += buttonCompleteTask_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Location = new Point(93, 204);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(75, 23);
            buttonDeleteTask.TabIndex = 4;
            buttonDeleteTask.Text = "Delete";
            buttonDeleteTask.UseVisualStyleBackColor = true;
            buttonDeleteTask.Click += buttonDeleteTask_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteTask);
            Controls.Add(textBox1);
            Controls.Add(buttonCompleteTask);
            Controls.Add(buttonAddTask);
            Controls.Add(listBox1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button buttonAddTask;
        private Button buttonCompleteTask;
        private TextBox textBox1;
        private Button buttonDeleteTask;
    }
}
