<?
require('fpdf.php');

function leerdoc($documento)
{
    $texto = file($documento);

    $tamleef = sizeof($texto);

    $pdf=new FPDF();

    for ($n = 0; $n < $tamleef; $n++)
    {
        $todo = $todo . $texto[$n];

            $pdf->AddPage();
            $pdf->SetFont('Arial','B',11);
            $pdf->Cell($n,10,$todo);
    }
    $pdf->Output();
}  
?>  