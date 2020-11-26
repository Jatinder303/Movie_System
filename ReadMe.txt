
 // Below query will find the propular Customer

  SELECT   TOP (100) PERCENT dbo.Customer.FirstName, COUNT(dbo.RentedMovies.CustIDFK) AS No_Of_Time_Movies_rented
	FROM     dbo.Customer INNER JOIN
             dbo.RentedMovies ON dbo.Customer.CustID = dbo.RentedMovies.CustIDFK
GROUP BY dbo.Customer.FirstName
ORDER BY No_Of_Time_Movies_rented DESC
 
 

 SELECT   TOP (100) PERCENT dbo.Movies.Title, COUNT(dbo.RentedMovies.MovieIDFK) AS No_Of_Time_Movies_rented
FROM     dbo.Movies INNER JOIN
             dbo.RentedMovies ON dbo.Movies.MovieID = dbo.RentedMovies.MovieIDFK
GROUP BY dbo.Movies.Title
ORDER BY No_Of_Time_Movies_rented DESC