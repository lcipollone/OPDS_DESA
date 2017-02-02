<?php
	// TEST PAGE
	require "WebService.php";
	require "PhpUtils.php";
	
	// TEST SOAP
	try {
		$topn = 25;
		// LLAMADO AL WS
		$client = new XMLClient();
		$ws = new WebService("http://footballpool.dataaccess.eu/data/info.wso?wsdl", $client);
	  	
		$result = $ws->call("TopGoalScorers", array("iTopN" => $topn));
		
	  	$array = $result->TopGoalScorersResult->tTopGoalScorer;
		// LLAMADO AL WS
	
	  	echo "
	    	<table border='2'>
		      	<tr>
			        <th>Rank</th>
			        <th>Name</th>
			        <th>Goals</th>
		    	</tr>
		  	";
	  
		foreach($array as $k=>$v){
			echo "
		    	<tr>
		        	<td align='right'>" . ($k+1) . "</td>
		          	<td>" . $v->sName . "</td>
		          	<td align='right'>" . $v->iGoals . "</td>
		        </tr>";
		}
	  
	  	echo "</table>";
	} catch (SOAPFault $exception) {
		echo  $exception;
		echo htmlspecialchars($client->__getLastRequest());
		exit;
	}
	
	// TEST REST - POST

	# WS = https://api.myjson.com/
	try{		
		//$data = array("t" => "titanic", "y" => 1997);
		$data = "";
		// LLAMADO AL WS
		$client = new JSONClient();
		$ws = new WebService("http://www.omdbapi.com", $client);
		
		$result = $ws->call("?t=titanic&y=1997", $data);
		
	  	$array = $result;
		// LLAMADO AL WS
		
	  	echo 	"<div>".
	  			"<img src='". $array->Poster . "'>" .
	  			"".
	  			"</div>";
	  	
	} catch (Exception $exception){
		echo  $exception;
	}

?>