'
' Created by SharpDevelop.
' User: ollie
' Date: 14/10/2021
' Time: 21:06
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		Dim userIn As Int64 = 0
		Const zero = 0
		
		Console.WriteLine("Please enter a positive intager . . . ")
		userIn = Val(Console.ReadLine())
		If userIn < 0 Then
			userIn = userIn * -1
		End If
		
		While userIn > 0
			Console.WriteLine(userIn)
			userIn = userIn - 1
		End While
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
