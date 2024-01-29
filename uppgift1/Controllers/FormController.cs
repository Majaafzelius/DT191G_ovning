// Controllers/FormController.cs
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Json;
using uppgift1.Models;

public class FormController : Controller
{
    private readonly string jsonFilePath = "/FormData.json";

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
public IActionResult SaveData(FormModel formData, string storageType)
{
    if (storageType == "cookie")
    {
        HttpContext.Response.Cookies.Append("FormData", JsonSerializer.Serialize(formData));
    }
    else if (storageType == "session")
    {
        HttpContext.Session.SetString("FormData", JsonSerializer.Serialize(formData));
    }
    else if (storageType == "json")
    {
        SaveToJsonFile(formData);
    }
    Console.Write(formData);
    return RedirectToAction("info");
}


    private void SaveToJsonFile(FormModel formData)
    {
        // Spara i JSON-fil
        var jsonData = JsonSerializer.Serialize(formData);
        System.IO.File.WriteAllText(jsonFilePath, jsonData);
    }

    public IActionResult DisplayData()
{
    FormModel formData = null;

    if (HttpContext.Request.Cookies.ContainsKey("FormData"))
    {
        formData = JsonSerializer.Deserialize<FormModel>(HttpContext.Request.Cookies["FormData"]);
    }
    else if (HttpContext.Session.Keys.Contains("FormData"))
    {
        formData = JsonSerializer.Deserialize<FormModel>(HttpContext.Session.GetString("FormData"));
    }
    else if (System.IO.File.Exists(jsonFilePath))
    {
        var jsonData = System.IO.File.ReadAllText(jsonFilePath);
        formData = JsonSerializer.Deserialize<FormModel>(jsonData);
    }

    ViewBag.FormData = formData;
    Console.Write(formData);

    return View();
}
}
