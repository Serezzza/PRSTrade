Option Explicit On
Option Strict On

Public Class Camera
    Inherits System.Windows.Forms.Form
    Private myCam As iCam

    Private isPhoto As Boolean = False
    Private number As Integer = 0
    Private isEd As Boolean = False

    Private Sub Camera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SimpleButton1.Text = "Сфотографировать"
        Me.picOutput.SizeMode = PictureBoxSizeMode.StretchImage
        myCam = New iCam
        SimpleButton1.Enabled = False
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If isPhoto = False Then
            myCam.closeCam()
            Application.DoEvents()
            myCam = Nothing
            Me.Close()
        Else
            myCam.resetCam()
            isPhoto = False
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If isPhoto = False Then
            If myCam.iRunning = True Then
                picOutput.Image = myCam.copyFrame(Me.picOutput, New RectangleF(0, 0, _
                                Me.picOutput.Width, Me.picOutput.Height))
                myCam.closeCam()
                SimpleButton1.Text = "Сохранить"
                isPhoto = True
            Else
                MessageBox.Show("Camera Is Not Running!")
            End If
        Else
            picOutput.Image.Save(cam_path & number & ".bmp")
            If isEd = False Then
                With Personal.DataGridView1
                    .Item(6, number).Value = cam_path & number & ".bmp"
                End With
                myCam.resetCam()
                Me.Close()
            Else
                With Personal_Add
                    .getPhotoPath(cam_path & number & ".bmp")
                End With
                myCam.resetCam()
                Me.Close()
            End If
            End If
    End Sub


    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        SimpleButton3.Enabled = False
        tmrUpdate.Start()
        myCam.initCam(Me.picOutput.Handle.ToInt32)
        SimpleButton1.Enabled = True
    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        With LabelControl2
            .Text = (myCam.FPS & " fps | " & _
                    "Running Status = " & myCam.iRunning)
        End With
    End Sub

    Public Sub getNumber(ByVal s As Integer, ByVal isEdit As Boolean)
        number = s
        isEd = isEdit
    End Sub
End Class