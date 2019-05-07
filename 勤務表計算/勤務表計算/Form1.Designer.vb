<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kinmuForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pathText = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.ExeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pathText
        '
        Me.pathText.Location = New System.Drawing.Point(12, 31)
        Me.pathText.Name = "pathText"
        Me.pathText.Size = New System.Drawing.Size(338, 19)
        Me.pathText.TabIndex = 0
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(358, 26)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(84, 29)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "参照"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'ExeButton
        '
        Me.ExeButton.Location = New System.Drawing.Point(330, 62)
        Me.ExeButton.Name = "ExeButton"
        Me.ExeButton.Size = New System.Drawing.Size(112, 29)
        Me.ExeButton.TabIndex = 2
        Me.ExeButton.Text = "実行"
        Me.ExeButton.UseVisualStyleBackColor = True
        '
        'kinmuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 103)
        Me.Controls.Add(Me.ExeButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.pathText)
        Me.Name = "kinmuForm"
        Me.Text = "勤務時間計算"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pathText As TextBox
    Friend WithEvents OKButton As Button
    Friend WithEvents ExeButton As Button
End Class
