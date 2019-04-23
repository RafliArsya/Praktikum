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
		<td>Diagonal-1</td>
		<td>:</td>
		<td><input type="text" name="Diagonal"/></td>
		</tr>
		<tr>
		<td>Diagonal-2</td>
		<td>:</td>
		<td><input type="text" name="Diagonala"/></td>
		</tr>
		<tr>
		<td></td>
		<td colspan="2"><input type="submit" value="Hitung" name="Hitung"/></td>
		</tr>
	</table>
</form>
<?php
if(isset($_POST['Hitung'], $_POST['Diagonal'], $_POST['Diagonala']))
{
	$d1 = $_POST['Diagonala'];
	$d0 = $_POST['Diagonal'];
	include 'calc.php';
	$calc = new bangunruang(); 
	$calc -> layang($d0, $d1);
}else{
	echo "Masukan Nilainya!";
}
?>