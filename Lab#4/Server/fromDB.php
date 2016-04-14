<?php
include("JSON.php");
if( !function_exists('json_encode') ) {
    function json_encode($data) {
        $json = new Services_JSON();
        return( $json->encode($data) );
    }
}
     $server="localhost";
     $database="labs";
	 $number_of_lab=$_REQUEST['value'];
	 $table="lab$number_of_lab";
$link = @mysqli_connect($server, "root", "70570", $database);
if (mysqli_connect_errno())  {
   header ('Location: http://localhost/name/index.html');
}


$sql = "SELECT * FROM $table";
$result = mysqli_query($link, $sql);
$array_user = array();
while ($data = mysqli_fetch_assoc($result)){
	$array_user[] = $data;
}
echo json_encode($array_user);
?>
