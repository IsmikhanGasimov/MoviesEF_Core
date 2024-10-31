// See https://aka.ms/new-console-template for more information
using MoviesEF_Core.Classes;
using MoviesEF_Core.Context;
using System.IO;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;



//using(StoredContext context = new())
//{

//    Directors directors = new Directors()
//    {
//        FirstName = "Silvester",
//        LastName="Stallone",
//        DateOfBirth=new DateTime(1965,8,9)

//    };

//    //context.Add(directors);

//    await context.Directorss.AddAsync(directors);
//    await context.SaveChangesAsync();
//}




using (StoredContext context = new())
{
    Movies movie = new Movies();

again:
    Console.WriteLine("1.Add ");
    Console.WriteLine("2.Update");
    Console.WriteLine("3.Delete ");
    Console.Write("Choose an Operation:");
    int opCase = Convert.ToInt32(Console.ReadLine());

    switch (opCase)
    {
        case 1:
            Console.WriteLine("MovieName:");
            movie.MovieName = Console.ReadLine();
            movie.MovieReleaseDate = DateTime.Now;
            Console.WriteLine("Description:");
            movie.Description = Console.ReadLine();
            Console.WriteLine("DirectorId:");
            movie.DirectorId = Convert.ToInt32(Console.ReadLine());
            await context.Moviess.AddAsync(movie);
            Console.WriteLine("Done!");
            await context.SaveChangesAsync();
            
            break;

        case 2:
            Console.WriteLine("Enter Movie Id:");
            int updateMovieId = Convert.ToInt32(Console.ReadLine());
            var updatedMovie = context.Moviess.FirstOrDefault(x => x.Id == updateMovieId);
            Console.WriteLine("Enter MovieName:");
            updatedMovie.MovieName = Console.ReadLine();
            Console.WriteLine("Enter Description:");
            updatedMovie.Description = Console.ReadLine();
            context.Update(updatedMovie);
            Console.WriteLine("Done!");
            await context.SaveChangesAsync();
            
            break;

        case 3:
            Console.WriteLine("Enter Movie id");
            int deletedMovieId = Convert.ToInt32(Console.ReadLine()); ;
            var deletedMovie = context.Moviess.FirstOrDefault(x => x.Id == deletedMovieId);
            context.Moviess.Remove(deletedMovie);
            Console.WriteLine("Done!");
            await context.SaveChangesAsync();

            break;

        default:
            Console.WriteLine("Wrong Operation!");
            break;
    }

    Console.WriteLine("Do you want to continue? ");
    string answer = Console.ReadLine().ToUpper();
    if (answer == "YES" || answer == "Y")
    {
        goto again;
    }
    else
    {
        Console.WriteLine("End of operations!");

    }

}


