<?php
session_start ();

$server="localhost";
$login=$_SESSION['login'];
$password=$_SESSION['password'];
$database="name";
$table="init";

$link = mysqli_connect($server, "root", "70570", $database);
if (mysqli_connect_errno())  {
   header ('Location: http://localhost/name/index.html');
}


   
?>

<html lang="en">
<head>
    <meta charset="UTF-8">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
    <script src="http://localhost/name/RequestsAjax.js"></script>
	<link rel="stylesheet" href="http://localhost/name/style.css" />
    <title>Information</title>
</head>
<body>
<table border=3  bgcolor=F0FFEA white=1000 width="800" align="center">
    <tr>
        <td height=100 colspan=4 align=center>
            <h1>Информация о лабораторной работе</h1>
        </td>
    </tr>
    <tr>
        <td height=100 colspan=4 align=center>
            <!--<FORM name="my_form" method="POST" action="http://localhost/name/fromDB.php">-->
                <span>
                    <h2>Лабораторная работа №
                    <input id="num" type="number" value="2" min="2" max="5" onkeypress="false;">
                    </h2>
                </span>
                <span>
                    <input type="submit" id="name" name="send" value=" OK " width="70px" onclick="AJAX(); return false;">
                </span>
            <!--</form>-->
        </td>
    </tr>
    <tr>
        <td>
            <div>
                <span>
                    <h3>Tema:</h3>
                </span>
                <span id="tema"></span>
            </div>
            <div>
                <span>
                    <h3>Obiective:</h3>
                </span>
                <span id="obiective"></span>
            </div>
            <div>
                <span>
                    <h3>Laboratory Requirements (basic):</h3>
                </span>
                <span id="basic"></span>
            </div>
            <div>
                <span>
                    <h3>Laboratory Requirements (normal):</h3>
                </span>
                <span id="normal"></span>
            </div>
            <div>
                <span>
                    <h3>Laboratory Requirements (advanced):</h3>
                </span>
                <span id="advanced"></span>
            </div>
            <div>
                <span>
                    <h3>Bonus-points:</h3>
                </span>
                <span id="bonus"></span>
            </div>
            <div>
                <span>
                    <h3>References:</h3>
                </span>
                <span id="ref"></span>
            </div>
        </td>
    </tr>
</table>
</body>
</html>