C# MvcMovie (Remind the MVC Skills)

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-5.0&tabs=visual-studio-code

PART I >>> GETSTART with ASP.NET CORE MVC
1) Create Web app
  dotnet new mvc -o MvcMovie
  code -r MvcMovie
2) Ctrl+F5 (Run Without Debugging) หรือ dotnet dev-dert http--trust
3) กด Yes

PART II >>> Add Controller to ASP.NET
1) ไปที่ Controller คลิ๊กขวา New File (HelloWorldController.cs)
2) Copy Code จากหน้าเพจไปวาง
https://docs.microsoft.com/th-th/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-2.2&tabs=visual-studio-code
3) Ctrl+F5 (Run Without Debugging)
  https://localhost:5001/HelloWorld
  This is my default action
  https://localhost:5001/HelloWorld/Welcome
  This is the Welcome action method
  
4) ลองแก้ Welcome โดยเพิ่ม parameter name กับ numTime ตามเว็บ
--------------------------------------------------------------------------------------
public string Welcome(string name, int numTimes = 1)
{
    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
}
--------------------------------------------------------------------------------------
https://localhost:5001/HelloWorld/Welcome?name=Rick&numtimes=4

--------------------------------------------------------------------------------------
public string Welcome(string name, int ID = 1)
{
    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
}
--------------------------------------------------------------------------------------
https://localhost:5001/HelloWorld/Welcome/3?name=Rick
