<?php
	class WebService {
	    var $url;
	    var $client;
	    
		function WebService ($url, $client) {
	        $this->url = $url;
	        $this->client = $client;
	    }
	    
	    function call($method, $params){
	    	$res = $this->client->call($this->url, $method, $params);
	    	return $res;	
	    }
	}
	
	class XMLClient{
		
		function XMLClient(){
		}
		
		function call($url, $method, $params){
	    	$ws = new SoapClient($url);
	    	$res = $ws->__call($method, array($params));
	    	return $res;	
	    }
	}
	
	class JSONClient{
		function JSONClient(){
		}
		
		function call($url, $method, $params){	
			
			if (is_array($params)){
				$ch = curl_init($url."/".$method);
				$data_string = json_encode($params);
				curl_setopt($ch, CURLOPT_POSTFIELDS, $data_string);
				curl_setopt($ch, CURLOPT_HTTPHEADER, array(
			    'Content-Type: application/json',
			    'Content-Length: ' . strlen($data_string)));
			}
			else{
				$ch = curl_init($url."/".$method.$params);
				curl_setopt($ch, CURLOPT_HTTPHEADER, array(
			    'Content-Type: application/json',
			    'Content-Length: ' . 0));
			}
			curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");
			curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
			curl_setopt($ch, CURLOPT_TIMEOUT, 5);
			curl_setopt($ch, CURLOPT_CONNECTTIMEOUT, 5);
			
			//execute post
			$res = curl_exec($ch);
			
			//close connection
			curl_close($ch);
			
			return json_decode($res); 
		}
	}
?>