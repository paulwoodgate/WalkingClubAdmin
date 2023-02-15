using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
namespace WalkPageGen
{
    public class SheetService
    {
        public string ApplicationName { get; set; }
        public string SpreadsheetId { get; set; }
        private readonly string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };

        public SheetService(string applicationName, string spreadSheetId)
        {
            SpreadsheetId = spreadSheetId;
            ApplicationName = applicationName;
        }

        public IList<IList<object>> GetData(string range)
        {
            var credential = GetOrGenerateCredential();
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(SpreadsheetId, range);

            ValueRange response = request.Execute();
            return response.Values;
        }

        private UserCredential GetOrGenerateCredential()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                const string credentialPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credentialPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credentialPath);
            }

            return credential;
        }
    }
}