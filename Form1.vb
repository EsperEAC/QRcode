Imports QRCoder
Imports System.Drawing
Imports System.IO

Public Class Form1
    Public QR_Result As Image
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub QR_Gen(ByVal URL As String)
        ' Define the URL for the QR code (or any string you want to encode)
        Dim qrContent As String = URL

        ' Create a QR code generator instance
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCoder.QRCode(qrCodeData)

        ' Create a QR code image
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(20, Color.Black, Color.White, True)

        ' Open a file dialog to let the user select the icon image
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" ' Restrict to image files

        Dim icon As Bitmap = Nothing

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected icon
            Dim iconPath As String = openFileDialog.FileName
            icon = New Bitmap(iconPath)

            ' Resize the icon/logo if necessary (optional)
            Dim iconSize As Integer = Math.Min(qrCodeImage.Width / 5, qrCodeImage.Height / 5)
            Dim resizedIcon As Bitmap = New Bitmap(icon, New Size(iconSize, iconSize))

            ' Combine the QR code and the icon
            Dim resultImage As Bitmap = New Bitmap(qrCodeImage.Width, qrCodeImage.Height)
            Using graphics As Graphics = Graphics.FromImage(resultImage)
                ' Draw the QR code on the result image
                graphics.DrawImage(qrCodeImage, 0, 0, qrCodeImage.Width, qrCodeImage.Height)

                ' Calculate the position to center the icon
                Dim x As Integer = (qrCodeImage.Width - resizedIcon.Width) / 2
                Dim y As Integer = (qrCodeImage.Height - resizedIcon.Height) / 2

                ' Draw the icon on the center of the QR code
                graphics.DrawImage(resizedIcon, x, y)
            End Using

            PictureBox1.Image = resultImage
            QR_Result = resultImage
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            ' Save the final image (QR code with icon) to a file
            'resultImage.Save("qr_code_with_icon.png", System.Drawing.Imaging.ImageFormat.Png)
            MsgBox("QR code with icon generated and saved as qr_code_with_icon.png")
        Else
            MsgBox("No icon selected. QR code generation aborted.")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QR_Gen(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PictureBox1.Image IsNot Nothing Then
            ' Use SaveFileDialog to let the user save the QR code
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PNG Files|*.png|JPEG Files|*.jpg;*.jpeg|BMP Files|*.bmp"
            saveFileDialog.Title = "Save QR Code Image"
            saveFileDialog.FileName = "qr_code_with_icon.png" ' Default file name

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Save the final image (QR code with icon) to the chosen path
                QR_Result.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png)
                MessageBox.Show("QR code with icon generated and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save operation was canceled.", "Save Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MsgBox("No image")
        End If


    End Sub
End Class

