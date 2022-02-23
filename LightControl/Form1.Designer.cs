
namespace LightControl
{
    partial class connectState
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.portNumber = new System.Windows.Forms.ComboBox();
            this.lightValue = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.lightKind = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.portState = new System.Windows.Forms.Label();
            this.dataShowBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // portNumber
            // 
            this.portNumber.FormattingEnabled = true;
            this.portNumber.Location = new System.Drawing.Point(12, 23);
            this.portNumber.Name = "portNumber";
            this.portNumber.Size = new System.Drawing.Size(121, 20);
            this.portNumber.TabIndex = 1;
            // 
            // lightValue
            // 
            this.lightValue.Location = new System.Drawing.Point(139, 68);
            this.lightValue.Name = "lightValue";
            this.lightValue.Size = new System.Drawing.Size(100, 21);
            this.lightValue.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(245, 67);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "송신";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendData);
            // 
            // lightKind
            // 
            this.lightKind.FormattingEnabled = true;
            this.lightKind.Location = new System.Drawing.Point(12, 67);
            this.lightKind.Name = "lightKind";
            this.lightKind.Size = new System.Drawing.Size(121, 20);
            this.lightKind.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Connect";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(139, 23);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "연결";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.PortConnet);
            // 
            // portState
            // 
            this.portState.AutoSize = true;
            this.portState.Location = new System.Drawing.Point(220, 31);
            this.portState.Name = "portState";
            this.portState.Size = new System.Drawing.Size(57, 12);
            this.portState.TabIndex = 8;
            this.portState.Text = "연결 상태";
            // 
            // dataShowBox
            // 
            this.dataShowBox.Location = new System.Drawing.Point(14, 96);
            this.dataShowBox.Name = "dataShowBox";
            this.dataShowBox.Size = new System.Drawing.Size(503, 131);
            this.dataShowBox.TabIndex = 9;
            this.dataShowBox.Text = "";
            // 
            // connectState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 239);
            this.Controls.Add(this.dataShowBox);
            this.Controls.Add(this.portState);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lightKind);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.lightValue);
            this.Controls.Add(this.portNumber);
            this.Name = "connectState";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox portNumber;
        private System.Windows.Forms.TextBox lightValue;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox lightKind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label portState;
        private System.Windows.Forms.RichTextBox dataShowBox;
    }
}

