using Heranca_Interface_Exercicio;
Console.WriteLine("Hello, World!");
//Json
SalvarJson salvarJson = new();
iSalvar iSave = salvarJson;

salvarJson.Nome();
iSave.compactar();
salvarJson.Salvar();
//xml
SalvarXML xML = new();
iSalvar iSalvar = xML;

xML.Nome();
iSalvar.compactar();
xML.Salvar();

Console.ReadKey();