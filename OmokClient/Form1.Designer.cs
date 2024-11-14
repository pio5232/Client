namespace OmokClient
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterButton = new System.Windows.Forms.Button();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portTB = new System.Windows.Forms.TextBox();
            this.roomListCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.connButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chattingRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(248, 771);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(261, 67);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "입장 버튼";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // ipTB
            // 
            this.ipTB.Location = new System.Drawing.Point(248, 27);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(261, 32);
            this.ipTB.TabIndex = 1;
            this.ipTB.Text = "127.0.0.1";
            this.ipTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "ip";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(248, 87);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(261, 32);
            this.portTB.TabIndex = 3;
            this.portTB.Text = "6000";
            this.portTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roomListCB
            // 
            this.roomListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.roomListCB.FormattingEnabled = true;
            this.roomListCB.Location = new System.Drawing.Point(248, 353);
            this.roomListCB.Name = "roomListCB";
            this.roomListCB.Size = new System.Drawing.Size(261, 392);
            this.roomListCB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "연결 상태";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connTB
            // 
            this.connTB.Location = new System.Drawing.Point(248, 150);
            this.connTB.Name = "connTB";
            this.connTB.Size = new System.Drawing.Size(261, 32);
            this.connTB.TabIndex = 6;
            this.connTB.Text = "연결 안 됨";
            this.connTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 61);
            this.label4.TabIndex = 8;
            this.label4.Text = "방 정보";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connButton
            // 
            this.connButton.Location = new System.Drawing.Point(248, 210);
            this.connButton.Name = "connButton";
            this.connButton.Size = new System.Drawing.Size(261, 67);
            this.connButton.TabIndex = 9;
            this.connButton.Text = "연결 버튼";
            this.connButton.UseVisualStyleBackColor = true;
            this.connButton.Click += new System.EventHandler(this.connButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(557, 794);
            this.textBox1.TabIndex = 10;
            // 
            // chattingRoom
            // 
            this.chattingRoom.Font = new System.Drawing.Font("굴림", 12F);
            this.chattingRoom.Location = new System.Drawing.Point(550, 45);
            this.chattingRoom.Name = "chattingRoom";
            this.chattingRoom.Size = new System.Drawing.Size(563, 62);
            this.chattingRoom.TabIndex = 11;
            this.chattingRoom.Text = "채팅창";
            this.chattingRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 1032);
            this.Controls.Add(this.chattingRoom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connTB);
            this.Controls.Add(this.roomListCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTB);
            this.Controls.Add(this.enterButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.ComboBox roomListCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox connTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label chattingRoom;
    }
}

