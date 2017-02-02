<?php 
	//Cliente SoapRedLink()
	$topn = 25;
	$client = new SoapClient("http://footballpool.dataaccess.eu/data/info.wso?wsdl");
  	
	//$result = $client->TopGoalScorers(array('iTopN' => $topn));
	$result = $client->__soapCall("TopGoalScorers", array('iTopN' => $topn)); //->TopGoalScorers(array('iTopN' => $topn));
	//Note that $array contains the result of the traversed object structure
  	$array = $result->TopGoalScorersResult->tTopGoalScorer;

  	print "
    	<table border='2'>
	      	<tr>
		        <th>Rank</th>
		        <th>Name</th>
		        <th>Goals</th>
	    	</tr>
	  	";
  
	foreach($array as $k=>$v){
		print "
	    	<tr>
	        	<td align='right'>" . ($k+1) . "</td>
	          	<td>" . $v->sName . "</td>
	          	<td align='right'>" . $v->iGoals . "</td>
	        </tr>";
	}
  
  	print "</table>";
?>