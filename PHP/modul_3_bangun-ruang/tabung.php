<?php
	include 'main.php';
?>
<form action="main.php">
	<table>
		<tr>
		<td></td>
		<td></td>
		<td></td>
		<td></td>
		<td></td>
		<td><input type="submit" value="back" name="Menu"/></td>
		</tr>
	</table>
</form>
<form method="post">
	<table>
		<tr>
		<td>Jari-jari</td>
		<td>:</td>
		<td><input type="text" name="r0"/></td>
		</tr>
		<tr>
		<td>Tinggi</td>
		<td>:</td>
		<td><input type="text" name="t0"/></td>
		</tr>
		<tr>
		<td></td>
		<td colspan="2"><input type="submit" value="Hitung" name="Hitung"/></td>
		</tr>
	</table>
</form>
<?php
if(isset($_POST['Hitung'], $_POST['r0'], $_POST['t0']))
{
	$a0 = $_POST['r0'];
	$b0 = $_POST['t0'];
	include 'calc.php';
	$calc = new bangunruang(); 
	$calc ->pthis($calc -> tabung($a0, $b0));
}else{
	echo "Masukan Nilainya!";
}
?>