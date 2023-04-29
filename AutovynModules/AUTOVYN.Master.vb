Public Class AUTOVYN
    Inherits System.Web.UI.MasterPage
    Private con As New Connection
    Private dp As New DbPath

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Brnch.Text = Session("Branch")
            'IP.Text = dp.SQLInstance
            Dim arr() = dp.SQLInstance.Split(".")
            IP.Text = arr(0).ToString + ".##.##." + arr(arr.Length - 1).ToString
            DB.Text = dp.DbName
            User.Text = Session("user_name")
            Curr_Date.Text = Now.ToString("M") + "-" + Now.ToString("yyyy")
        Catch ex As Exception

        End Try

    End Sub

    'Protected Sub Cashier_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cashier_8_1.Click
    '    Try
    '        Dim CashierCode = Convert.ToString(con.ExecuteScaler("select max(Post_AC) as Post_AC from user_tbl where user_name = '" + Session("user_name") + "' and export_type <3"))
    '        If (Convert.ToString(CashierCode) <> "") Then

    '            Session("cashCode") = CashierCode
    '            Response.Redirect("~/AutovynModules/Modules/Cashier/Cashier.aspx")
    '        Else
    '            MsgBox("Cash ledger selection allowed through cashier login only!")
    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub
End Class