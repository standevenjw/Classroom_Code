<!DOCTYPE html>
<html>
<head>
  <meta charset='utf-8' />
  <title>Assignment 3</title>
  <!--
    James Standeven
    April 6, 2013
    Assignment 3
  -->
</head>
<body>
  <!-- Create Form -->
  <form method='post' action='assignment3.php'>
  Enter Z-number: <input type='text' name='Znum' /><br />
  Enter gpa: <input type='text' name='gpa' /><br />
  <input type='submit' value='Submit Request' />
  </form>

<?php
  
  //Connect to mysql
  $con=mysqli_connect("localhost") or die("Failed to connect to MySQL: ".mysqli_connect_error());

/*THESE STEPS MAY NOT BE NECESSARY FOR THE ASSIGNMENT*/
  
  //Select database
  $db= mysqli_select_db($con, "db_J11007382");

  if(!$db){
    // Create database
    $sql="CREATE DATABASE db_J11007382";
    mysqli_query($con,$sql) or die("Error creating database: ".mysqli_error($con));
    $db= mysqli_select_db($con, "db_J11007382");
  } 
 
/*THESE STEPS MAY NOT BE NECESSARY FOR THE ASSIGNMENT //END//*/
  
  // Create table
  $sql="CREATE TABLE IF NOT EXISTS Students(Znum CHAR(9) NOT NULL, gpa FLOAT NOT NULL)";

  // Execute query
  mysqli_query($con,$sql) or die("Error creating table: ".mysqli_error($con));
  
  //Insert user data
  if(!empty($_POST)){    
    mysqli_query($con,"INSERT INTO Students(Znum, gpa) VALUES ('$_POST[Znum]', '$_POST[gpa]')") or die("Error inserting 
data: ".mysqli_error($con));
    echo "Operation succedded.";
  }
  else{
    echo 'You must enter data in both fields.';
  }
  
  //Get data from table
  $result = mysqli_query($con,"SELECT * FROM Students") or die("Error retrieving data: ".mysqli_error($con));
  
  //Display table data to user
  echo "<table border='1'>
  <tr>
  <th>Znum</th>
  <th>GPA</th>
  </tr>";

  while($row = mysqli_fetch_array($result))
  {
    echo "<tr>";
    echo "<td>" . $row['Znum'] . "</td>";
    echo "<td>" . $row['gpa'] . "</td>";
    echo "</tr>";
  }
  echo "</table>";

  mysqli_close($con);
?>
</body>
</html>
