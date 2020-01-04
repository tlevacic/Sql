namespace sql
{
    partial class Form2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.execute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.connectionBtn = new System.Windows.Forms.Button();
            this.connectionInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textQuery = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.execute);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.displayBox);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.textQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 503);
            this.panel2.TabIndex = 1;
            // 
            // clearBtn
            // 
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("FontAwesome", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(185, 328);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // execute
            // 
            this.execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute.Font = new System.Drawing.Font("FontAwesome", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute.ForeColor = System.Drawing.Color.White;
            this.execute.Location = new System.Drawing.Point(732, 328);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(149, 32);
            this.execute.TabIndex = 6;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("FontAwesome", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(181, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sql Editor";
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.Location = new System.Drawing.Point(181, 380);
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.Size = new System.Drawing.Size(700, 110);
            this.displayBox.TabIndex = 4;
            this.displayBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.connectionBtn);
            this.panel1.Controls.Add(this.connectionInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 501);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("FontAwesome", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set database connection";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectionBtn
            // 
            this.connectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionBtn.Font = new System.Drawing.Font("FontAwesome", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.connectionBtn.Location = new System.Drawing.Point(16, 455);
            this.connectionBtn.Name = "connectionBtn";
            this.connectionBtn.Size = new System.Drawing.Size(146, 34);
            this.connectionBtn.TabIndex = 2;
            this.connectionBtn.Text = "Connect";
            this.connectionBtn.UseVisualStyleBackColor = true;
            this.connectionBtn.Click += new System.EventHandler(this.connectionBtn_Click);
            // 
            // connectionInfo
            // 
            this.connectionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.connectionInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionInfo.ForeColor = System.Drawing.Color.Red;
            this.connectionInfo.Location = new System.Drawing.Point(16, 54);
            this.connectionInfo.Name = "connectionInfo";
            this.connectionInfo.ReadOnly = true;
            this.connectionInfo.Size = new System.Drawing.Size(146, 267);
            this.connectionInfo.TabIndex = 1;
            this.connectionInfo.Text = "You are not connected!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FontAwesome", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // textQuery
            // 
            this.textQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textQuery.Font = new System.Drawing.Font("FontAwesome", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuery.ForeColor = System.Drawing.Color.White;
            this.textQuery.Location = new System.Drawing.Point(185, 54);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(696, 268);
            this.textQuery.TabIndex = 2;
            this.textQuery.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 503);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "SQL Editor";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox textQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button connectionBtn;
        private System.Windows.Forms.RichTextBox connectionInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button button1;
    }
}