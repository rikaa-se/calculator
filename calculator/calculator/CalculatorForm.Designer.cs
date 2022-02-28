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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.EqualButton = new System.Windows.Forms.Button();
            this.DisplayNumberLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayTextLabel = new System.Windows.Forms.Label();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.PeriodButton = new System.Windows.Forms.Button();
            this.Number0Button = new System.Windows.Forms.Button();
            this.Number1Button = new System.Windows.Forms.Button();
            this.Number2Button = new System.Windows.Forms.Button();
            this.Number3Button = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.Number6Button = new System.Windows.Forms.Button();
            this.Number5Button = new System.Windows.Forms.Button();
            this.Number4Button = new System.Windows.Forms.Button();
            this.Number7Button = new System.Windows.Forms.Button();
            this.Number8Button = new System.Windows.Forms.Button();
            this.Number9Button = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EqualButton
            // 
            this.EqualButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EqualButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EqualButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualButton.Location = new System.Drawing.Point(205, 410);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(95, 67);
            this.EqualButton.TabIndex = 0;
            this.EqualButton.Text = "＝";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // DisplayNumberLabel
            // 
            this.DisplayNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayNumberLabel.AutoSize = true;
            this.DisplayNumberLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.DisplayNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.DisplayNumberLabel, 4);
            this.DisplayNumberLabel.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.DisplayNumberLabel.Location = new System.Drawing.Point(3, 33);
            this.DisplayNumberLabel.Name = "DisplayNumberLabel";
            this.DisplayNumberLabel.Size = new System.Drawing.Size(400, 86);
            this.DisplayNumberLabel.TabIndex = 1;
            this.DisplayNumberLabel.Tag = "0";
            this.DisplayNumberLabel.Text = "0";
            this.DisplayNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tableLayoutPanel1.Controls.Add(this.DisplayTextLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DisplayNumberLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdditionButton, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.EqualButton, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.PeriodButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Number0Button, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Number1Button, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Number2Button, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Number3Button, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.SubtractionButton, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.MultiplicationButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Number6Button, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Number5Button, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Number4Button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Number7Button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Number8Button, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Number9Button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.DivisionButton, 3, 3);
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
            // DisplayTextLabel
            // 
            this.DisplayTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayTextLabel.AutoSize = true;
            this.DisplayTextLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.DisplayTextLabel, 4);
            this.DisplayTextLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTextLabel.ForeColor = System.Drawing.Color.Black;
            this.DisplayTextLabel.Location = new System.Drawing.Point(3, 0);
            this.DisplayTextLabel.Name = "DisplayTextLabel";
            this.DisplayTextLabel.Size = new System.Drawing.Size(400, 33);
            this.DisplayTextLabel.TabIndex = 3;
            this.DisplayTextLabel.Tag = "0";
            this.DisplayTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdditionButton
            // 
            this.AdditionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionButton.BackColor = System.Drawing.Color.Linen;
            this.AdditionButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionButton.Location = new System.Drawing.Point(306, 410);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(97, 67);
            this.AdditionButton.TabIndex = 4;
            this.AdditionButton.Text = "＋";
            this.AdditionButton.UseVisualStyleBackColor = false;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // PeriodButton
            // 
            this.PeriodButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodButton.BackColor = System.Drawing.Color.White;
            this.PeriodButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeriodButton.Location = new System.Drawing.Point(104, 410);
            this.PeriodButton.Name = "PeriodButton";
            this.PeriodButton.Size = new System.Drawing.Size(95, 67);
            this.PeriodButton.TabIndex = 9;
            this.PeriodButton.Text = "・";
            this.PeriodButton.UseVisualStyleBackColor = false;
            this.PeriodButton.Click += new System.EventHandler(this.PeriodButton_Click);
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
            // SubtractionButton
            // 
            this.SubtractionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtractionButton.BackColor = System.Drawing.Color.Linen;
            this.SubtractionButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractionButton.Location = new System.Drawing.Point(306, 338);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(97, 66);
            this.SubtractionButton.TabIndex = 5;
            this.SubtractionButton.Text = "ー";
            this.SubtractionButton.UseVisualStyleBackColor = false;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiplicationButton.BackColor = System.Drawing.Color.Linen;
            this.MultiplicationButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicationButton.Location = new System.Drawing.Point(306, 266);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(97, 66);
            this.MultiplicationButton.TabIndex = 6;
            this.MultiplicationButton.Text = "×";
            this.MultiplicationButton.UseVisualStyleBackColor = false;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
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
            // DivisionButton
            // 
            this.DivisionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionButton.BackColor = System.Drawing.Color.Linen;
            this.DivisionButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionButton.ForeColor = System.Drawing.Color.Black;
            this.DivisionButton.Location = new System.Drawing.Point(306, 194);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(97, 66);
            this.DivisionButton.TabIndex = 7;
            this.DivisionButton.Text = "÷";
            this.DivisionButton.UseVisualStyleBackColor = false;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
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
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "0";
            this.Text = "簡易電卓 - Ver1.10";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Label DisplayNumberLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button Number0Button;
        private System.Windows.Forms.Button PeriodButton;
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
        private System.Windows.Forms.Label DisplayTextLabel;
    }
}

