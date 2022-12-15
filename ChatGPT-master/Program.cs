using ChatGPT;
using System.Text.Json;

public class Program
{
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}



//            var client = new HttpClient();

//// Set the authorization header for the request
//client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "API_KEY");

//// Create a JSON object to hold the request parameters


//string myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
//string filePath = Path.Combine(myDocsPath, "conversation.json");
//HttpResponseMessage response;

//while (true)
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.Write("Ask: ");
//    string line = Console.ReadLine();


//        var requestParams = new
//        {
//            prompt = line,
//            model = "text-davinci-002",
//            max_tokens = 128,
//            echo = true,
//        };

//        // Convert the request parameters to a JSON string

//        var requestJson = System.Text.Json.JsonSerializer.Serialize(requestParams);
//        // Create a new HttpContent object to hold the request JSON
//        var requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");


//        // Send the request to the OpenAI API and receive the response
//        response = await client.PostAsync("https://api.openai.com/v1/completions", requestContent);


//    // Read the response JSON from the response object
//    if (await response.Content.ReadAsStringAsync() is string responseJson)
//    {
       

//        // Deserialize the response JSON into a dynamic object
//        var responseObject = JsonSerializer.Deserialize<Response>(responseJson);

//        // Save first
//        var formattedJson = JsonSerializer.Serialize(responseObject, options: new JsonSerializerOptions { WriteIndented = true });
//        File.AppendAllText(filePath, formattedJson);
//        File.AppendAllText(filePath, $",{Environment.NewLine}");


//        if (responseObject.error is Error error)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine(error.message);

//            Console.ForegroundColor = ConsoleColor.DarkGray;            
//            Console.WriteLine(responseJson);
//        }
//        else

//        foreach (var choice in responseObject.choices)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine(choice.text);
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine(choice.finish_reason);

//            Console.ForegroundColor = ConsoleColor.DarkGray;
//            Console.WriteLine(responseJson);

//        }
//    }

//    // Get the generated text from the response object
//    //    var generatedText = responseObject.

//    // Output the generated text
//    //  Console.WriteLine(generatedText);

//}
