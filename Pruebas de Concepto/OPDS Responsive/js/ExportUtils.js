function excelExportTable(event)
{
	var tableId = event.data.table;
	var filename = event.data.filename;
	var uri = 'data:application/vnd.ms-excel;base64,';
	var template = '<html xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:x="urn:schemas-microsoft-com:office:excel" xmlns="http://www.w3.org/TR/REC-html40"><head><!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>{worksheet}</x:Name><x:WorksheetOptions><x:DisplayGridlines/></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]--></head><body><table>{table}</table></body></html>'; 
	var base64 = function(s) {
		return window.btoa(unescape(encodeURIComponent(s)))
	};

	var format = function(s, c) {
		return s.replace(/{(\w+)}/g, function(m, p) {
			return c[p];
		})
	};

	var tab_text="<table border='2px'><tr bgcolor='#87AFC6'>";
	var textRange; var j=0;
	tab = document.getElementById(tableId);

	for(j = 0 ; j < tab.rows.length ; j++) 
	{     
		tab_text=tab_text+tab.rows[j].innerHTML+"</tr>";
		//tab_text=tab_text+"</tr>";
	}

	tab_text=tab_text+"</table>";
	tab_text= tab_text.replace(/<A[^>]*>|<\/A>/g, "");//remove if u want links in your table
	tab_text= tab_text.replace(/<img[^>]*>/gi,""); // remove if u want images in your table
	tab_text= tab_text.replace(/<input[^>]*>|<\/input>/gi, ""); // reomves input params

	if (navigator.msSaveBlob) 
	{
		var blobObject = new Blob([tab_text]); 
		navigator.msSaveBlob(blobObject, filename + '.xls');
    }
    else 
    {
		var link = document.createElement('a');
		if (typeof link.download === 'string') {
		    link.href = 'data:application/vnd.ms-excel,' + encodeURIComponent(tab_text);
		    link.download = filename + '.xls';
		}
		else{
            link.href = window.URL.createObjectURL(tab_text);
            link.setAttribute('download', filename + '.xls');
		}
        document.body.appendChild(link);    
        link.click();
        document.body.removeChild(link);  	
    }
}

function exportTableButton(buttonId, tableId, exportType, fileName)
{
	if (exportType && exportType.toLowerCase() == "excel")
	{
		var btn = $("#" + buttonId);
		btn.bind("click", {table: tableId, filename: fileName}, excelExportTable);
	}
}