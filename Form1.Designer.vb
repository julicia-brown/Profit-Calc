<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picCoin = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClesr = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblProfitMarginHeader = New System.Windows.Forms.Label()
        Me.lblProfitHeader = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblProfitM = New System.Windows.Forms.Label()
        Me.lblProfit = New System.Windows.Forms.Label()
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCoin
        '
        Me.picCoin.BackColor = System.Drawing.SystemColors.Control
        Me.picCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCoin.Image = CType(resources.GetObject("picCoin.Image"), System.Drawing.Image)
        Me.picCoin.Location = New System.Drawing.Point(54, 46)
        Me.picCoin.Name = "picCoin"
        Me.picCoin.Size = New System.Drawing.Size(511, 734)
        Me.picCoin.TabIndex = 0
        Me.picCoin.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Ink Free", 19.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(710, 46)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(418, 130)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Entreprenuer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Profit Calculator"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.PowderBlue
        Me.btnCalc.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(762, 604)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(352, 88)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClesr
        '
        Me.btnClesr.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnClesr.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClesr.Location = New System.Drawing.Point(815, 715)
        Me.btnClesr.Name = "btnClesr"
        Me.btnClesr.Size = New System.Drawing.Size(269, 76)
        Me.btnClesr.TabIndex = 3
        Me.btnClesr.Text = "Clear"
        Me.btnClesr.UseVisualStyleBackColor = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Ebrima", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(631, 276)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(340, 37)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "What's your listed Price?:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Ebrima", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(631, 329)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(412, 37)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "What's  your production Cost?:"
        '
        'lblProfitMarginHeader
        '
        Me.lblProfitMarginHeader.AutoSize = True
        Me.lblProfitMarginHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfitMarginHeader.Location = New System.Drawing.Point(636, 496)
        Me.lblProfitMarginHeader.Name = "lblProfitMarginHeader"
        Me.lblProfitMarginHeader.Size = New System.Drawing.Size(189, 31)
        Me.lblProfitMarginHeader.TabIndex = 6
        Me.lblProfitMarginHeader.Text = "Profit Margin:"
        Me.lblProfitMarginHeader.Visible = False
        '
        'lblProfitHeader
        '
        Me.lblProfitHeader.AutoSize = True
        Me.lblProfitHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfitHeader.Location = New System.Drawing.Point(1005, 496)
        Me.lblProfitHeader.Name = "lblProfitHeader"
        Me.lblProfitHeader.Size = New System.Drawing.Size(93, 31)
        Me.lblProfitHeader.TabIndex = 7
        Me.lblProfitHeader.Text = "Profit:"
        Me.lblProfitHeader.Visible = False
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(1000, 273)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(159, 40)
        Me.txtPrice.TabIndex = 8
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(1063, 326)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(159, 40)
        Me.txtCost.TabIndex = 9
        '
        'lblProfitM
        '
        Me.lblProfitM.AutoSize = True
        Me.lblProfitM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfitM.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblProfitM.Location = New System.Drawing.Point(831, 496)
        Me.lblProfitM.Name = "lblProfitM"
        Me.lblProfitM.Size = New System.Drawing.Size(101, 31)
        Me.lblProfitM.TabIndex = 10
        Me.lblProfitM.Text = "Label3"
        Me.lblProfitM.Visible = False
        '
        'lblProfit
        '
        Me.lblProfit.AutoSize = True
        Me.lblProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfit.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblProfit.Location = New System.Drawing.Point(1121, 496)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(101, 31)
        Me.lblProfit.TabIndex = 11
        Me.lblProfit.Text = "Label4"
        Me.lblProfit.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1289, 830)
        Me.Controls.Add(Me.lblProfit)
        Me.Controls.Add(Me.lblProfitM)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblProfitHeader)
        Me.Controls.Add(Me.lblProfitMarginHeader)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnClesr)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picCoin)
        Me.Name = "Form1"
        Me.Text = "Profit Calculator"
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCoin As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClesr As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblProfitMarginHeader As Label
    Friend WithEvents lblProfitHeader As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lblProfitM As Label
    Friend WithEvents lblProfit As Label
End Class
