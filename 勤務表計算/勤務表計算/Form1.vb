Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Public Class kinmuForm
    Dim csvPath As String = ""          'csvファイルのパス

    '参照ボタンの処理
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim OpenFileDialog1 As New OpenFileDialog()

        OpenFileDialog1.Title = "ファイル選択"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "CSVファイル|*.csv"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pathText.Text = OpenFileDialog1.FileName
            csvPath = pathText.Text
        End If
    End Sub

    '実行ボタンの処理
    Private Sub ExeButton_Click(sender As Object, e As EventArgs) Handles ExeButton.Click
        Dim stResult As String()      '配列
        Dim totalTime As TimeSpan     '合計時間
        Dim startTime As DateTime     '始業時間格納
        Dim endTime As DateTime       '就業時間格納
        Dim stBuffer As String        '読み込み用
        Dim overTime As TimeSpan      '残業時間用

        Dim strDfaultTime As String = "19:00"       '就業時刻
        Dim defaultTime As DateTime = DateTime.Parse(strDfaultTime)     '終業時刻をDateTime方型に変換
        Dim cnt As String()

        'ファイルが存在していなかったら終了
        If System.IO.File.Exists(csvPath) = False Then
            MessageBox.Show("ファイルが存在しません。", "エラー")
            Exit Sub
        End If

        'StreamReader の新しいインスタンスを生成する
        Dim sr As New System.IO.StreamReader(csvPath, System.Text.Encoding.GetEncoding("shift_jis"))

        'FileInfo の新しいインスタンスを生成する
        Dim cFileInfo As New System.IO.FileInfo(csvPath)

        'ファイルサイズが0なら終了
        If cFileInfo.Length = 0 Then
            MessageBox.Show("空ファイルです。", "エラー")
            Exit Sub
        End If

        '1行飛ばす(項目)
        sr.ReadLine()

        'csv読み込み
        stBuffer = sr.ReadLine()

        'カンマ区切り
        cnt = stBuffer.Split(","c)

        '読み込みできる文字がなくなるまで繰り返す
        While (sr.Peek() > -1)
            'ファイルを 1 行ずつ読み込む
            stBuffer = sr.ReadLine()

            'カンマ区切りで配列に格納
            stResult = stBuffer.Split(","c)

            '始業時刻または就業時刻の中身がNULLだったらなにもしない
            If stResult(4) = "" Or stResult(5) = "" Then
                Continue While
            End If

            'startTimeに始業時間を格納
            startTime = DateTime.Parse(stResult(4))

            'endTimeに就業時間を格納
            endTime = DateTime.Parse(stResult(5))

            '勤務時間の計算
            totalTime += endTime - startTime

            '残業時間計算
            If endTime > defaultTime Then
                overTime += endTime - defaultTime
            End If
        End While

        'cReaderを閉じる
        sr.Close()

        'メッセージボックスに出力
        MessageBox.Show("総勤務時間は" & totalTime.TotalHours() & "時間です。" & Environment.NewLine & "残業時間は" & overTime.TotalHours() & "時間です。", "総勤務時間")
    End Sub
End Class
