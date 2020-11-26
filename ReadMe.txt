
 // Below query will find the propular Customer

SELECT  Customer.FirstName As Customer_Name,
		count(RentedMovies.CustIDFK) As No_Of_Time_Movies_rented

  FROM [Video_Rental_System].[dbo].[RentedMovies],
  [Video_Rental_System].[dbo].[Customer]
	
  where RentedMovies.CustIDFK = Customer.CustID
  Group By Customer.FirstName 
  Order By No_Of_Time_Movies_rented DESC

 
 // Below query will find the propular Video
 
 SELECT   Movies.Title As Movie_Name,
		count(RentedMovies.MovieIDFK) As No_Of_Time_Movies_rented

  FROM [Video_Rental_System].[dbo].[RentedMovies],
  [Video_Rental_System].[dbo].[Movies]
  
  where  RentedMovies.MovieIDFK = Movies.MovieID

  Group By Movies.Title 
  Order By No_Of_Time_Movies_rented DESC
  

