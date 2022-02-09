namespace calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculationButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Number7Button = new System.Windows.Forms.Button();
            this.Number8Button = new System.Windows.Forms.Button();
            this.Number9Button = new System.Windows.Forms.Button();
            this.Number0Button = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.Number4Button = new System.Windows.Forms.Button();
            this.Number5Button = new System.Windows.Forms.Button();
            this.Number6Button = new System.Windows.Forms.Button();
            this.Number1Button = new System.Windows.Forms.Button();
            this.Number2Button = new System.Windows.Forms.Button();
            this.Number3Button = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.DifferenceButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.QuotientButton = new System.Windows.Forms.Button();
            this.ResultTextLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculationButton
            // 
            this.CalculationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CalculationButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationButton.Location = new System.Drawing.Point(205, 410);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(95, 67);
            this.CalculationButton.TabIndex = 0;
            this.CalculationButton.Text = "＝";
            this.CalculationButton.UseVisualStyleBackColor = false;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.ResultLabel, 4);
            this.ResultLabel.Font = new System.Drawing.Font("Nirmala UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Black;
            this.ResultLabel.Location = new System.Drawing.Point(3, 33);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(400, 86);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Tag = "0";
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ResultTextLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ResultLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SumButton, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.CalculationButton, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.PointButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Number0Button, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Number1Button, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Number2Button, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Number3Button, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.DifferenceButton, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.ProductButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Number6Button, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Number5Button, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Number4Button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Number7Button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Number8Button, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Number9Button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.QuotientButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ClearButton, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 480);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Number7Button
            // 
            this.Number7Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number7Button.BackColor = System.Drawing.Color.White;
            this.Number7Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number7Button.Location = new System.Drawing.Point(3, 194);
            this.Number7Button.Name = "Number7Button";
            this.Number7Button.Size = new System.Drawing.Size(95, 66);
            this.Number7Button.TabIndex = 16;
            this.Number7Button.Text = "7";
            this.Number7Button.UseVisualStyleBackColor = false;
            this.Number7Button.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number8Button
            // 
            this.Number8Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number8Button.BackColor = System.Drawing.Color.White;
            this.Number8Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number8Button.Location = new System.Drawing.Point(104, 194);
            this.Number8Button.Name = "Number8Button";
            this.Number8Button.Size = new System.Drawing.Size(95, 66);
            this.Number8Button.TabIndex = 17;
            this.Number8Button.Text = "8";
            this.Number8Button.UseVisualStyleBackColor = false;
            this.Number8Button.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number9Button
            // 
            this.Number9Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number9Button.BackColor = System.Drawing.Color.White;
            this.Number9Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number9Button.Location = new System.Drawing.Point(205, 194);
            this.Number9Button.Name = "Number9Button";
            this.Number9Button.Size = new System.Drawing.Size(95, 66);
            this.Number9Button.TabIndex = 18;
            this.Number9Button.Text = "9";
            this.Number9Button.UseVisualStyleBackColor = false;
            this.Number9Button.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number0Button
            // 
            this.Number0Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number0Button.BackColor = System.Drawing.Color.White;
            this.Number0Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number0Button.Location = new System.Drawing.Point(3, 410);
            this.Number0Button.Name = "Number0Button";
            this.Number0Button.Size = new System.Drawing.Size(95, 67);
            this.Number0Button.TabIndex = 8;
            this.Number0Button.Text = "0";
            this.Number0Button.UseVisualStyleBackColor = false;
            this.Number0Button.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // PointButton
            // 
            this.PointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PointButton.BackColor = System.Drawing.Color.White;
            this.PointButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointButton.Location = new System.Drawing.Point(104, 410);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(95, 67);
            this.PointButton.TabIndex = 9;
            this.PointButton.Text = "・";
            this.PointButton.UseVisualStyleBackColor = false;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // Number4Button
            // 
            this.Number4Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number4Button.BackColor = System.Drawing.Color.White;
            this.Number4Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number4Button.Location = new System.Drawing.Point(3, 266);
            this.Number4Button.Name = "Number4Button";
            this.Number4Button.Size = new System.Drawing.Size(95, 66);
            this.Number4Button.TabIndex = 13;
            this.Number4Button.Text = "4";
            this.Number4Button.UseVisualStyleBackColor = false;
            this.Number4Button.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number5Button
            // 
            this.Number5Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number5Button.BackColor = System.Drawing.Color.White;
            this.Number5Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number5Button.Location = new System.Drawing.Point(104, 266);
            this.Number5Button.Name = "Number5Button";
            this.Number5Button.Size = new System.Drawing.Size(95, 66);
            this.Number5Button.TabIndex = 14;
            this.Number5Button.Text = "5";
            this.Number5Button.UseVisualStyleBackColor = false;
            this.Number5Button.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number6Button
            // 
            this.Number6Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number6Button.BackColor = System.Drawing.Color.White;
            this.Number6Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number6Button.Location = new System.Drawing.Point(205, 266);
            this.Number6Button.Name = "Number6Button";
            this.Number6Button.Size = new System.Drawing.Size(95, 66);
            this.Number6Button.TabIndex = 15;
            this.Number6Button.Text = "6";
            this.Number6Button.UseVisualStyleBackColor = false;
            this.Number6Button.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number1Button
            // 
            this.Number1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number1Button.BackColor = System.Drawing.Color.White;
            this.Number1Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1Button.Location = new System.Drawing.Point(3, 338);
            this.Number1Button.Name = "Number1Button";
            this.Number1Button.Size = new System.Drawing.Size(95, 66);
            this.Number1Button.TabIndex = 10;
            this.Number1Button.Text = "1";
            this.Number1Button.UseVisualStyleBackColor = false;
            this.Number1Button.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number2Button
            // 
            this.Number2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number2Button.BackColor = System.Drawing.Color.White;
            this.Number2Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2Button.Location = new System.Drawing.Point(104, 338);
            this.Number2Button.Name = "Number2Button";
            this.Number2Button.Size = new System.Drawing.Size(95, 66);
            this.Number2Button.TabIndex = 11;
            this.Number2Button.Text = "2";
            this.Number2Button.UseVisualStyleBackColor = false;
            this.Number2Button.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number3Button
            // 
            this.Number3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number3Button.BackColor = System.Drawing.Color.White;
            this.Number3Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number3Button.Location = new System.Drawing.Point(205, 338);
            this.Number3Button.Name = "Number3Button";
            this.Number3Button.Size = new System.Drawing.Size(95, 66);
            this.Number3Button.TabIndex = 12;
            this.Number3Button.Text = "3";
            this.Number3Button.UseVisualStyleBackColor = false;
            this.Number3Button.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel1.SetColumnSpan(this.ClearButton, 2);
            this.ClearButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(205, 122);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(198, 66);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SumButton
            // 
            this.SumButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SumButton.BackColor = System.Drawing.Color.Linen;
            this.SumButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumButton.Location = new System.Drawing.Point(306, 410);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(97, 67);
            this.SumButton.TabIndex = 4;
            this.SumButton.Text = "＋";
            this.SumButton.UseVisualStyleBackColor = false;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // DifferenceButton
            // 
            this.DifferenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DifferenceButton.BackColor = System.Drawing.Color.Linen;
            this.DifferenceButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifferenceButton.Location = new System.Drawing.Point(306, 338);
            this.DifferenceButton.Name = "DifferenceButton";
            this.DifferenceButton.Size = new System.Drawing.Size(97, 66);
            this.DifferenceButton.TabIndex = 5;
            this.DifferenceButton.Text = "ー";
            this.DifferenceButton.UseVisualStyleBackColor = false;
            this.DifferenceButton.Click += new System.EventHandler(this.DifferenceButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductButton.BackColor = System.Drawing.Color.Linen;
            this.ProductButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductButton.Location = new System.Drawing.Point(306, 266);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(97, 66);
            this.ProductButton.TabIndex = 6;
            this.ProductButton.Text = "×";
            this.ProductButton.UseVisualStyleBackColor = false;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // QuotientButton
            // 
            this.QuotientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuotientButton.BackColor = System.Drawing.Color.Linen;
            this.QuotientButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuotientButton.ForeColor = System.Drawing.Color.Black;
            this.QuotientButton.Location = new System.Drawing.Point(306, 194);
            this.QuotientButton.Name = "QuotientButton";
            this.QuotientButton.Size = new System.Drawing.Size(97, 66);
            this.QuotientButton.TabIndex = 7;
            this.QuotientButton.Text = "÷";
            this.QuotientButton.UseVisualStyleBackColor = false;
            this.QuotientButton.Click += new System.EventHandler(this.QuotientButton_Click);
            // 
            // ResultTextLabel
            // 
            this.ResultTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextLabel.AutoSize = true;
            this.ResultTextLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.ResultTextLabel, 4);
            this.ResultTextLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ResultTextLabel.Location = new System.Drawing.Point(3, 0);
            this.ResultTextLabel.Name = "ResultTextLabel";
            this.ResultTextLabel.Size = new System.Drawing.Size(400, 33);
            this.ResultTextLabel.TabIndex = 3;
            this.ResultTextLabel.Tag = "0";
            this.ResultTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "0";
            this.Text = "簡易電卓";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button DifferenceButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button QuotientButton;
        private System.Windows.Forms.Button Number0Button;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button Number1Button;
        private System.Windows.Forms.Button Number2Button;
        private System.Windows.Forms.Button Number3Button;
        private System.Windows.Forms.Button Number6Button;
        private System.Windows.Forms.Button Number5Button;
        private System.Windows.Forms.Button Number4Button;
        private System.Windows.Forms.Button Number9Button;
        private System.Windows.Forms.Button Number8Button;
        private System.Windows.Forms.Button Number7Button;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ResultTextLabel;
    }
}

