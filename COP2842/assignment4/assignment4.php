<!DOCTYPE html>
<html>
<head>
  <meta charset='utf-8' />
  <title>Assignment 4</title>
  <!--
    James Standeven
    April 16, 2013
    Assignment 4
  -->
</head>
<body onload='getFocus(); ischecked();'>
  <!-- Create Form -->
  <form method='post' action='assignment4.php' name='form1'>
  <input type='radio' name='dbopt' value='insert' id='insert' onchange='ischecked()'>Insert student</input><br />
  <input type='radio' name='dbopt' value='update' id='update' onchange='ischecked()'>Update student</input><br />
  <input type='radio' name='dbopt' value='delete' id='delete' onchange='ischecked()'>Delete student</input><br />
  <p id='output'></p>
  
  <script type='text/javascript'>
    <!--
    function ischecked(){
	  //Get control of the p element
      var output = document.getElementById('output');
      //Get control of the radio button
      var radio = document.getElementById('insert');
      if(radio.checked === true){//Test if insert is checked
        output.innerHTML = "Enter Z-number: <input type='text' name='Znum' /><br />Enter gpa: <input type='text' name='gpa' />";
      }
	  //Change to next radio button
      radio = document.getElementById('update');
      if(radio.checked === true){//Test if update is checked
        output.innerHTML = "Enter Z-number: <input type='text' name='Znum' /><br />Enter new gpa: <input type='text' name='gpa' />";
      }
	  //Change to next radio button
      radio = document.getElementById('delete');
      if(radio.checked === true){//Test if delete is checked
        output.innerHTML = "Enter Z-number: <input type='text' name='Znum' />";
      } 
    }
    function getFocus(){
      var radio = document.getElementById('update');
      radio.focus();//Give update focus
      radio.checked = 'checked';//Make update checked
    }
    //-->
  </script>
  <input type='submit' value='Submit Request' />
  </form>


<?php

  if(!empty($_POST)){     
    //Connect to mysql
    $con=mysqli_connect("localhost") or die("Failed to connect to MySQL: ".mysqli_connect_error());

    /*THESE STEPS MAY NOT BE NECESSARY FOR THE ASSIGNMENT*/
  
    //Select database
    $db= mysqli_select_db($con, "db_J11007382");
  
    //If selecting database failed, create database
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
  
    $radio = $_POST['dbopt'];

    if($radio == 'insert'){
      //Insert user data
      mysqli_query($con,"INSERT INTO Students(Znum, gpa) VALUES ('$_POST[Znum]', '$_POST[gpa]')") or die("Error inserting data: ".mysqli_error($con));
      echo "Operation succedded.";
    }
    else if($radio == 'update'){
      //Update user data
      mysqli_query($con,"UPDATE Students SET gpa='$_POST[gpa]' WHERE Znum='$_POST[Znum]'") or die("Error updating data: ".mysqli_error($con));
      echo "Operation succedded."; 
    }
    else if($radio == 'delete'){
      //Delete user 
      mysqli_query($con,"DELETE FROM Students WHERE Znum='$_POST[Znum]'") or die("Error deleting student: ".mysqli_error($con));
      echo "Operation succedded."; 
    
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
  }
?>
</body>
</html>

