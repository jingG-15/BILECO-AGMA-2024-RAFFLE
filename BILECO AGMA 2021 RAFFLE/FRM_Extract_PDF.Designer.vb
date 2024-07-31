<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Extract_PDF
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Extract_PDF))
        Me.Side_Pan_Dis_CB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Extract_Btn = New Guna.UI.WinForms.GunaButton()
        Me.Extract_PDF_Circ_Bar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Export_PDF_BW = New System.ComponentModel.BackgroundWorker()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'Side_Pan_Dis_CB
        '
        Me.Side_Pan_Dis_CB.Animated = True
        Me.Side_Pan_Dis_CB.BackColor = System.Drawing.Color.Transparent
        Me.Side_Pan_Dis_CB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Side_Pan_Dis_CB.BorderRadius = 15
        Me.Side_Pan_Dis_CB.BorderThickness = 2
        Me.Side_Pan_Dis_CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Side_Pan_Dis_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Side_Pan_Dis_CB.FillColor = System.Drawing.Color.LightGray
        Me.Side_Pan_Dis_CB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Side_Pan_Dis_CB.FocusedColor = System.Drawing.Color.Empty
        Me.Side_Pan_Dis_CB.FocusedState.Parent = Me.Side_Pan_Dis_CB
        Me.Side_Pan_Dis_CB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Side_Pan_Dis_CB.ForeColor = System.Drawing.Color.Black
        Me.Side_Pan_Dis_CB.FormattingEnabled = True
        Me.Side_Pan_Dis_CB.HoverState.Parent = Me.Side_Pan_Dis_CB
        Me.Side_Pan_Dis_CB.ItemHeight = 30
        Me.Side_Pan_Dis_CB.ItemsAppearance.Parent = Me.Side_Pan_Dis_CB
        Me.Side_Pan_Dis_CB.Location = New System.Drawing.Point(12, 39)
        Me.Side_Pan_Dis_CB.Name = "Side_Pan_Dis_CB"
        Me.Side_Pan_Dis_CB.ShadowDecoration.Parent = Me.Side_Pan_Dis_CB
        Me.Side_Pan_Dis_CB.Size = New System.Drawing.Size(211, 36)
        Me.Side_Pan_Dis_CB.TabIndex = 66
        '
        'Extract_Btn
        '
        Me.Extract_Btn.Animated = True
        Me.Extract_Btn.AnimationHoverSpeed = 0.07!
        Me.Extract_Btn.AnimationSpeed = 0.03!
        Me.Extract_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Extract_Btn.BaseColor = System.Drawing.Color.Transparent
        Me.Extract_Btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Extract_Btn.BorderSize = 2
        Me.Extract_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Extract_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Extract_Btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Extract_Btn.ForeColor = System.Drawing.Color.Black
        Me.Extract_Btn.Image = Nothing
        Me.Extract_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Extract_Btn.Location = New System.Drawing.Point(12, 81)
        Me.Extract_Btn.Name = "Extract_Btn"
        Me.Extract_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Extract_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Extract_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Extract_Btn.OnHoverImage = Nothing
        Me.Extract_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Extract_Btn.Radius = 26
        Me.Extract_Btn.Size = New System.Drawing.Size(211, 57)
        Me.Extract_Btn.TabIndex = 65
        Me.Extract_Btn.Text = "Extract"
        Me.Extract_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Extract_PDF_Circ_Bar
        '
        Me.Extract_PDF_Circ_Bar.Animated = True
        Me.Extract_PDF_Circ_Bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Extract_PDF_Circ_Bar.ForeColor = System.Drawing.Color.Black
        Me.Extract_PDF_Circ_Bar.Location = New System.Drawing.Point(23, -6)
        Me.Extract_PDF_Circ_Bar.Name = "Extract_PDF_Circ_Bar"
        Me.Extract_PDF_Circ_Bar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid
        Me.Extract_PDF_Circ_Bar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Extract_PDF_Circ_Bar.ShadowDecoration.Parent = Me.Extract_PDF_Circ_Bar
        Me.Extract_PDF_Circ_Bar.Size = New System.Drawing.Size(182, 144)
        Me.Extract_PDF_Circ_Bar.TabIndex = 67
        Me.Extract_PDF_Circ_Bar.Visible = False
        '
        'Export_PDF_BW
        '
        Me.Export_PDF_BW.WorkerReportsProgress = True
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(69, 9)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(88, 21)
        Me.GunaLabel3.TabIndex = 68
        Me.GunaLabel3.Text = "Batch No :"
        '
        'FRM_Extract_PDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 144)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.Extract_PDF_Circ_Bar)
        Me.Controls.Add(Me.Side_Pan_Dis_CB)
        Me.Controls.Add(Me.Extract_Btn)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Extract_PDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export to PDF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Side_Pan_Dis_CB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Extract_Btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Extract_PDF_Circ_Bar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Export_PDF_BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
End Class
