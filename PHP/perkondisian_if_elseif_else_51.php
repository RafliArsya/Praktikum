<?php
	echo "<h2> pilih PTN </h2>";
	echo "1.undip<br>";
	echo "2.unnes<br><hr>";
	
	$ptn = "2";
	
	if ($ptn =="1"){
		echo " undip, universitas diponegoro<br>";
	}
	else if ($ptn =="2"){
		echo " universitas negeri semarang<br>";
	}else{
		echo "program salah";
	}
	
?>