Console.Write("Digite o dia: ");
int dia = int.Parse(Console.ReadLine());

Console.Write("Digite o mês: ");
int mes = int.Parse(Console.ReadLine());

Console.Write("Digite o ano: ");
int ano = int.Parse(Console.ReadLine());

DateTime dataDeHoje = DateTime.Now;
DateTime data = new DateTime(ano, mes, dia, 05, 30, 00);
TimeSpan horario = new TimeSpan(05, 30, 00);
string formatacaoPersonalizada = data.ToString("yyyy-MM-dd HH:mm:ss.fff");

Console.WriteLine("");
Console.WriteLine("DataTime Now: " + dataDeHoje);
Console.WriteLine("DataTime Date: " + data.Date);
Console.WriteLine("DataTime ToLongDateString(): " + data.ToLongDateString());
Console.WriteLine("DataTime ToShortDateString(): " + data.ToShortDateString());
Console.WriteLine("DataTime Usando Formatação Personalizada: " + formatacaoPersonalizada);
Console.WriteLine("DataTime ToLongTimeString: " + data.ToLongTimeString());
Console.WriteLine("DataTime ToShortTimeString: " + data.ToShortTimeString());
Console.WriteLine("Horário ToString: " + horario.ToString());

