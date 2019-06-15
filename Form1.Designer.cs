namespace Pimpo_FellowshipEntry
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_Members = new System.Windows.Forms.ListBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_EditMem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbx_Savelist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbx_Members
            // 
            this.lbx_Members.FormattingEnabled = true;
            this.lbx_Members.Location = new System.Drawing.Point(12, 62);
            this.lbx_Members.Name = "lbx_Members";
            this.lbx_Members.Size = new System.Drawing.Size(281, 173);
            this.lbx_Members.TabIndex = 0;
            this.lbx_Members.SelectedIndexChanged += new System.EventHandler(this.lbx_Members_SelectedIndexChanged);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(12, 241);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(301, 241);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save to File";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(93, 241);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add Member";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Blackadder ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(37, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(258, 34);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Members of the Fellowship";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(439, 241);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_EditMem
            // 
            this.btn_EditMem.Location = new System.Drawing.Point(174, 241);
            this.btn_EditMem.Name = "btn_EditMem";
            this.btn_EditMem.Size = new System.Drawing.Size(121, 23);
            this.btn_EditMem.TabIndex = 5;
            this.btn_EditMem.Text = "Edit Selected Member";
            this.btn_EditMem.UseVisualStyleBackColor = true;
            this.btn_EditMem.Click += new System.EventHandler(this.btn_EditMem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbx_Savelist
            // 
            this.lbx_Savelist.FormattingEnabled = true;
            this.lbx_Savelist.Location = new System.Drawing.Point(299, 62);
            this.lbx_Savelist.Name = "lbx_Savelist";
            this.lbx_Savelist.Size = new System.Drawing.Size(215, 173);
            this.lbx_Savelist.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(526, 271);
            this.Controls.Add(this.lbx_Savelist);
            this.Controls.Add(this.btn_EditMem);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.lbx_Members);
            this.Name = "Form1";
            this.Text = "View Fellowship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Members;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_EditMem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox lbx_Savelist;
    }
}

