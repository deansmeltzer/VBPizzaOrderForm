Public Class Form1
    Private Sub BtnNext1_Click_1(sender As Object, e As EventArgs) Handles BtnNext1.Click

        Dim smallPrice As Double = 10.99
        Dim smallCheck As String = RadBSmall.Text
        If RadBSmall.Checked Then
            Console.WriteLine("Pizza Size is: " & RadBSmall.Text)
        Else
        End If

        Dim medPrice As Double = 12.99
        Dim medCheck As String = RadBMed.Text
        If RadBMed.Checked Then
            Console.WriteLine("Pizza Size is: " & RadBMed.Text)
        Else
        End If

        Dim lgPrice As Double = 14.99
        Dim lgCheck As String = RadBLg.Text
        If RadBLg.Checked Then
            Console.WriteLine("Pizza Size is: " & RadBLg.Text)
        Else
        End If

        Dim regPrice As Double = 1.99
        Dim regCheck As String = RadBRegular.Text
        If RadBRegular.Checked Then
            Console.WriteLine("Crust type is: " & RadBRegular.Text)
        Else
        End If

        Dim thinPrice As Double = 0.99
        Dim thinCheck As String = RadBThin.Text
        If RadBThin.Checked Then
            Console.WriteLine("Crust type is: " & RadBThin.Text)
        Else
        End If

        Dim cheese As String = RadBCheese.Checked
        Console.WriteLine("Cheese? " & RadBCheese.Checked)

        Dim pepperoniPriceSmall As Double = 0.5
        Dim pepperoniPriceMed As Double = 0.75
        Dim pepperoniPriceLg As Double = 0.99
        Dim pepperoniCheck As String = CBPepperoni.Text
        Console.WriteLine("Add Pepperoni? " & CBPepperoni.Checked)

        Dim sausagePriceSmall As Double = 0.5
        Dim sausagePriceMed As Double = 0.75
        Dim sausagePriceLg As Double = 0.99
        Dim sausageCheck As String = CBSausage.Text
        Console.WriteLine("Add Sausage? " & CBSausage.Checked)

        Dim canBaconPriceSmall As Double = 0.5
        Dim canBaconPriceMed As Double = 0.75
        Dim canBaconPriceLg As Double = 0.99
        Dim canBaconCheck As String = CBCanBacon.Text
        Console.WriteLine("Add Canadian Bacon? " & CBCanBacon.Checked)

        Dim baconPriceSmall As Double = 0.5
        Dim baconPriceMed As Double = 0.75
        Dim baconPriceLg As Double = 0.99
        Dim baconCheck As String = CBBacon.Text
        Console.WriteLine("Add Bacon? " & CBBacon.Checked)

        Dim bPeppersPriceSmall As Double = 0.5
        Dim bPeppersPriceMed As Double = 0.75
        Dim bPeppersPriceLg As Double = 0.99
        Dim bPeppersCheck As String = CBBellPeppers.Text
        Console.WriteLine("Add Bell Peppers? " & CBBellPeppers.Checked)

        Dim olivesPriceSmall As Double = 0.5
        Dim olivesPriceMed As Double = 0.75
        Dim olivesPriceLg As Double = 0.99
        Dim olivesCheck As String = CBOlives.Text
        Console.WriteLine("Add Olives? " & CBOlives.Checked)

        Dim anchoviesPriceSmall As Double = 0.5
        Dim anchoviesPriceMed As Double = 0.75
        Dim anchoviesPriceLg As Double = 0.99
        Dim anchoviesCheck As String = CBAnchovies.Text
        Console.WriteLine("Add Anchovies? " & CBAnchovies.Checked)

        Dim mushroomsPriceSmall As Double = 0.5
        Dim mushroomsPriceMed As Double = 0.75
        Dim mushroomsPriceLg As Double = 0.99
        Dim mushroomsCheck As String = CBMushrooms.Text
        Console.WriteLine("Add Mushrooms? " & CBMushrooms.Checked)

        Dim parmCheese As String = CBParmCheese.Text
        Console.WriteLine("Add Cheese Packet? " & CBParmCheese.Checked)

        Dim redPeppers As String = CBCrushedPeppers.Text
        Console.WriteLine("Add Crushed Red Peppers? " & CBCrushedPeppers.Checked)

        Dim ranch As String = CBRanch.Text
        Console.WriteLine("Add Ranch Dressing? " & CBRanch.Checked)

        'Additional Topping Price Notification
        If RadBSmall.Checked Then
            Console.WriteLine("Additional toppings cost $.50 each.")
        Else
        End If

        If RadBMed.Checked Then
            Console.WriteLine("Additional toppings cost $.75 each.")
        Else
        End If

        If RadBLg.Checked Then
            Console.WriteLine("Additional toppings cost $.99 each.")
        End If

        Console.WriteLine("Quantity: " & Qnty.Value)

        'Error Messages
        If Not (RadBSmall.Checked Or RadBMed.Checked Or RadBLg.Checked) Then
            MessageBox.Show("Please select pizza size.")
        Else
        End If

        If Not (RadBRegular.Checked Or RadBThin.Checked) Then
            MessageBox.Show("Please select a crust type.")
        Else
        End If

        If Not (RadBCheese.Checked Or RadBNoCheese.Checked) Then
            MessageBox.Show("Please select whether or not you'd like cheese.")
        Else
        End If

        If Qnty.Value > 5 Then
            MessageBox.Show("For any order of more than 5 pizzas, please call the store at (555) 555-5555 to place your order!")
        End If

        'Topping Counter
        Dim toppingCount As Integer =
        IIf(CBPepperoni.Checked, 1, 0) +
        IIf(CBSausage.Checked, 1, 0) +
        IIf(CBCanBacon.Checked, 1, 0) +
        IIf(CBBacon.Checked, 1, 0) +
        IIf(CBOlives.Checked, 1, 0) +
        IIf(CBAnchovies.Checked, 1, 0) +
        IIf(CBMushrooms.Checked, 1, 0) +
        IIf(CBBellPeppers.Checked, 1, 0)
        Console.WriteLine(toppingCount)

        'Small Pizza Price Combinations
        Dim subTotalPrice As Double = Label4.Text
        If toppingCount < 4 And RadBSmall.Checked Then
            Label4.Text = 10.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0)
        ElseIf toppingCount = 4 And RadBSmall.Checked Then
            Label4.Text = 10.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +0.5
        ElseIf toppingCount = 5 And RadBSmall.Checked Then
            Label4.Text = 10.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +1.0
        ElseIf toppingCount = 6 And RadBSmall.Checked Then
            Label4.Text = 10.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +1.5
        ElseIf toppingCount = 7 And RadBSmall.Checked Then
            Label4.Text = 10.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +2.0
        ElseIf toppingCount = 8 And RadBSmall.Checked Then
            Label4.Text = 10.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +2.5
        Else
        End If

        'Medium Pizza Price Combinations
        If toppingCount < 4 And RadBMed.Checked Then
            Label4.Text = 12.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0)
        ElseIf toppingCount = 4 And RadBMed.Checked Then
            Label4.Text = 12.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +0.75
        ElseIf toppingCount = 5 And RadBMed.Checked Then
            Label4.Text = 12.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +1.5
        ElseIf toppingCount = 6 And RadBMed.Checked Then
            Label4.Text = 12.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +2.25
        ElseIf toppingCount = 7 And RadBMed.Checked Then
            Label4.Text = 12.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +3.0
        ElseIf toppingCount = 8 And RadBMed.Checked Then
            Label4.Text = 12.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +3.75
        End If

        'Large Pizza Price Combinations
        If toppingCount < 4 And RadBLg.Checked Then
            Label4.Text = 14.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0)
        ElseIf toppingCount = 4 And RadBLg.Checked Then
            Label4.Text = 14.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +0.99
        ElseIf toppingCount = 5 And RadBLg.Checked Then
            Label4.Text = 14.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +1.98
        ElseIf toppingCount = 6 And RadBLg.Checked Then
            Label4.Text = 14.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +2.97
        ElseIf toppingCount = 7 And RadBLg.Checked Then
            Label4.Text = 14.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +3.96
        ElseIf toppingCount = 8 And RadBLg.Checked Then
            Label4.Text = 14.99 +
                IIf(RadBRegular.Checked, regPrice, 0) +
                IIf(RadBThin.Checked, thinPrice, 0) +
                +4.95
        End If

        If Qnty.Value > 1 Then
            Dim totalPrice As Double = subTotalPrice.ToString
            Label4.Text = Qnty.Value * totalPrice
        Else
        End If
        'Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Width = 320
        Label1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Width = 640
        Label1.Focus()
    End Sub

    Private Sub RadBSmall_Checked(sender As Object, e As EventArgs) Handles RadBSmall.Click
        Label3.Text = "First 3 toppings are free. Additional toppings are $.50 each."
    End Sub

    Private Sub RadBMed_Checked(sender As Object, e As EventArgs) Handles RadBMed.Click
        Label3.Text = "First 3 toppings are free. Additional toppings are $.75 each."
    End Sub

    Private Sub RadBLg_Checked(sender As Object, e As EventArgs) Handles RadBLg.Click
        Label3.Text = "First 3 toppings are free. Additional toppings are $.99 each."
    End Sub
End Class
