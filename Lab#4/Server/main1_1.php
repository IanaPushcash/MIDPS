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

if (mysqli_query($link,"INSERT INTO $table (login, password) VALUES ('$login', '$password')")) {
   session_start ();
   $_SESSION['login']=$login;
   $_SESSION['password']=$password;
   header ('Location: http://localhost/name/main2.php');
}
else {
header ('Location: http://localhost/name/index.html');
}

?>