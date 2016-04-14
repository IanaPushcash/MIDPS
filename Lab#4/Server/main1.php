<?php
     $server="localhost";
     $login=$_POST['login'];
     $password=$_POST['password'];
     $database="name";
	 $table="init";

$link = mysqli_connect($server, "root", "70570", $database);
if (mysqli_connect_errno())  {
	
   header ('Location: http://localhost/name/index.html');
}

if ($result = mysqli_query($link,"SELECT * FROM $table WHERE login='$login' AND password='$password'")) {
   //echo "<script>console.log($result->num_rows);</script>";
   if ($result->num_rows > 0){
   session_start ();
   $_SESSION['login']=$login;
   $_SESSION['password']=$password;
   header ('Location: http://localhost/name/main2.php');
   }
   else {
	header ('Location: http://localhost/name/index.html');
	}
	
   mysqli_free_result($result);
}
else {
header ('Location: http://localhost/name/index.html');
}

?>