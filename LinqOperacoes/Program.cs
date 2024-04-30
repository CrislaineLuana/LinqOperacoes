
using Dumpify;
using System.Linq;

IEnumerable<int> listaNumeros = [5, 2, 3, 4, 1, 8, 7];
IEnumerable<int> listaNumeros2 = [8, 9, 10, 11, 12, 13, 14];


IEnumerable<string> listaTexto = ["a", "b", "c", "d", "e", "f"];



IEnumerable<Pessoa> pessoas = [
        new ("Fernanda", 15),
        new ("Lucas", 18),
        new ("Carlos", 18),
        new ("Eduarda", 17),
        new ("Mia", 12),
        new ("Caio", 11),
        new ("Felipe", 11),
        new ("Rogerio", 11),
      ];


record Pessoa (string nome, int idade);


//OrderBy e OrderByDescending
//pessoas.OrderBy(x => x.idade).Dump();
//pessoas.OrderByDescending(x => x.idade).Dump();

//Order e OrderDescending
//listaNumeros.Order().Dump();
//listaNumeros.OrderDescending().Dump();

//GroupBy
//pessoas.GroupBy(x => x.idade).Dump();

//Concat
//listaNumeros.Concat(listaNumeros2).Dump();

//Zip
//listaNumeros.Zip(listaTexto).Dump();

//Distinct e DistinctBy
//listaNumeros.Distinct().Dump();
//pessoas.DistinctBy(x => x.nome).Dump();

//Range e Repeat
//IEnumerable<int> listaRange = Enumerable.Range(0, 100);
//listaRange.ToList().Dump();

//IEnumerable<int> listaRange = Enumerable.Repeat(1, 10);
//listaRange.ToList().Dump();

//ToList
//listaNumeros.ToList().Dump();

//ElementAt e ElementAtOrDefault
//listaNumeros.ElementAt(6).Dump();
//listaNumeros.ElementAtOrDefault(6).Dump();

//Last e LastOrDefault
//listaNumeros.Last().Dump();
//listaNumeros.LastOrDefault().Dump();

//Single e SingleOrDefault
//listaNumeros.Single().Dump();
//listaNumeros.SingleOrDefault().Dump();

//First e FirstOrDefault
//listaNumeros.First().Dump();
//listaNumeros.FirstOrDefault(-1).Dump();

//Average
//listaNumeros.Average().Dump();

////Sum
//listaNumeros.Sum().Dump();

//MaxBy e MinBy
//pessoas.MaxBy(x => x.idade).Dump();
//pessoas.MinBy(x => x.idade).Dump();

//Max e Min
//listaNumeros.Max().Dump();
//listaNumeros.Min().Dump();

//Count
//listaNumeros.Count().Dump(); 

//Append e Prepend
//listaNumeros.Append(15).Dump();
//listaNumeros.Prepend(20).Dump();

//Contains
//listaNumeros.Contains(15).Dump();


//All
//listaNumeros.All(x => x > 2).Dump();



//Any
//listaNumeros.Any(x => x >15).Dump();


//Chunk
//listaNumeros.Chunk(3).Dump();

//WHERE 
//listaNumeros.Where(num => num > 5).Dump();

//Skip e Take
//listaNumeros.Skip(5).Dump();
//listaNumeros.Take(5).Dump();

//SkipLast e TakeLast
//listaNumeros.SkipLast(5).Dump();
//listaNumeros.TakeLast(5).Dump();

//SkipWhile e TakeWhile
//listaNumeros.SkipWhile(x => x < 5).Dump();
//listaNumeros.TakeWhile(x => x < 5).Dump();