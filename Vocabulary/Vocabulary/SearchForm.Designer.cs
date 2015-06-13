namespace Vocabulary
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lookForPages = new System.Windows.Forms.CheckBox();
            this.lookForWords = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchExpression = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.ListBox();
            this.beCaseSensitive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lookForPages
            // 
            this.lookForPages.AutoSize = true;
            this.lookForPages.Checked = true;
            this.lookForPages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lookForPages.Location = new System.Drawing.Point(19, 98);
            this.lookForPages.Name = "lookForPages";
            this.lookForPages.Size = new System.Drawing.Size(56, 17);
            this.lookForPages.TabIndex = 1;
            this.lookForPages.Text = "Pages";
            this.lookForPages.UseVisualStyleBackColor = true;
            this.lookForPages.CheckedChanged += new System.EventHandler(this.lookForPages_CheckedChanged);
            // 
            // lookForWords
            // 
            this.lookForWords.AutoSize = true;
            this.lookForWords.Checked = true;
            this.lookForWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lookForWords.Location = new System.Drawing.Point(19, 121);
            this.lookForWords.Name = "lookForWords";
            this.lookForWords.Size = new System.Drawing.Size(57, 17);
            this.lookForWords.TabIndex = 2;
            this.lookForWords.Text = "Words";
            this.lookForWords.UseVisualStyleBackColor = true;
            this.lookForWords.CheckedChanged += new System.EventHandler(this.lookForWords_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Look for:";
            // 
            // searchExpression
            // 
            this.searchExpression.Location = new System.Drawing.Point(12, 508);
            this.searchExpression.Name = "searchExpression";
            this.searchExpression.Size = new System.Drawing.Size(533, 20);
            this.searchExpression.TabIndex = 4;
            this.searchExpression.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search results";
            // 
            // results
            // 
            this.results.FormattingEnabled = true;
            this.results.Location = new System.Drawing.Point(12, 182);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(533, 316);
            this.results.TabIndex = 6;
            // 
            // beCaseSensitive
            // 
            this.beCaseSensitive.AutoSize = true;
            this.beCaseSensitive.Location = new System.Drawing.Point(156, 98);
            this.beCaseSensitive.Name = "beCaseSensitive";
            this.beCaseSensitive.Size = new System.Drawing.Size(94, 17);
            this.beCaseSensitive.TabIndex = 7;
            this.beCaseSensitive.Text = "Case-sensitive";
            this.beCaseSensitive.UseVisualStyleBackColor = true;
            this.beCaseSensitive.CheckedChanged += new System.EventHandler(this.beCaseSensitive_CheckedChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 540);
            this.Controls.Add(this.beCaseSensitive);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchExpression);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookForWords);
            this.Controls.Add(this.lookForPages);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox lookForPages;
        private System.Windows.Forms.CheckBox lookForWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchExpression;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox results;
        private System.Windows.Forms.CheckBox beCaseSensitive;
    }
}