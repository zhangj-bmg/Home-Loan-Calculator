'*************************************
'
' Author: Mr. Zhang
' Email: zhangj@bmg.vic.edu.au
'
'*************************************

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Calculate relevant home loan information based on the inputs.
        ' Input Variables
        Dim existingMortgage As Integer = Val(tboExistingMortgage.Text)
        Dim priceOldHome As Integer = Val(tboPriceOldHome.Text)
        Dim priceNewHome As Integer = Val(tboPriceNewHome.Text)

        Dim passValidation As Boolean = False

        ' Output Variables 
        Dim agentCommission As Integer
        Dim depositNewHome As Integer
        Dim stampDuty As Integer
        Dim newMortgage As Integer

        ' Validation
        If Not IsNumeric(tboExistingMortgage.Text) Or Not IsNumeric(tboPriceNewHome.Text) Or Not IsNumeric(tboPriceOldHome.Text) Then
            MsgBox("Please input a numerical value.")
        ElseIf (Val(existingMortgage) < 0) Or (Val(priceOldHome) < 0) Or (Val(priceNewHome) < 0) Then
            MsgBox("Please input a positive value.")
        Else
            passValidation = True
        End If

        If passValidation Then

            ' Calculation
            agentCommission = priceOldHome * 2.5 / 100
            depositNewHome = priceOldHome - existingMortgage - agentCommission
            stampDuty = 0.03 * (priceNewHome - depositNewHome)
            newMortgage = (priceNewHome - depositNewHome) + stampDuty

            tboAgentCommission.Text = Str(agentCommission)
            tboNewHomeDeposit.Text = Str(depositNewHome)
            tboStampDuty.Text = Str(stampDuty)

            ' Checking for government approval
            If newMortgage / priceNewHome < 0.8 Then
                MsgBox("Loan approved!" + vbNewLine + vbNewLine + "New Mortage is: " + Str(newMortgage))
            Else
                MsgBox("Loan denied.")
            End If

        End If




    End Sub
End Class
