param($installPath, $toolsPath, $package, $project)

try
{	
	ForEach($projectItem in $DTE.Solution.Projects )  
	{	
		#Reading Azure project file form the solution
		if ( $projectItem.FullName.EndsWith(“.ccproj”) )
		{			
			[XML]$xml = Get-Content $projectItem.FullName								
			
			#Create an xml element 
			$solutionNode = $xml.CreateElement("SolutionDir",$XML.DocumentElement.NamespaceURI)
			$solutionNode.InnerText = "..\..\source\"	
			$solutionNode.SetAttribute('Condition', '$(SolutionDir) == '''' Or $(SolutionDir) == ''*Undefined*''') 					
			$xml.Project["PropertyGroup"].AppendChild($solutionNode)													
		
			$importNode =  $xml.CreateElement("Import",$XML.DocumentElement.NamespaceURI)			
			$importNode.SetAttribute('Project', '$(SolutionDir)\packages\Windows.Azure.BuildHelpers.' + $package.Version + '\build\Microsoft.WindowsAzure.targets')
			$xml.Project.AppendChild($importNode)											
			
			If($xml.HasChildNodes)
			{
				#change the attribute value
				if($xml.Project.HasAttributes)				
				{					
					$xml.Project.SetAttribute("DefaultTargets","Publish;Build")
				}
				
				if($xml.Project.HasChildNodes)
				{
					#updating an xml nodes				
					ForEach($importItem in $xml.Project.Import)
					{			
						if ($importItem.getAttribute("Project") -eq '$(CloudExtensionsDir)Microsoft.WindowsAzure.targets')
				   		{			 
							$importItem.ParentNode.ReplaceChild($importItem.OwnerDocument.CreateComment($importItem.OuterXml), $importItem)						
						}
					}
				}
			}			
	
			$temp = "True"			
	
			While ($temp -eq "True")
			{
				If($xml.HasChildNodes)
				{
					ForEach($propertyGroup in $xml.Project.PropertyGroup)
					{
						If($propertyGroup.HasChildNodes)
						{
							ForEach($item in $propertyGroup.ChildNodes)
							{
								If($item.Name -eq "CloudExtensionsDir" )
								{			   							
									#Create and updating an xml elements
									$projectGroupNode = $xml.CreateElement("ServiceHostingSDKInstallDir",$XML.DocumentElement.NamespaceURI)
									$projectGroupNode.InnerText = '$(SolutionDir)\packages\Windows.Azure.SDK.1.6\'			   				
									$propertyGroup.AppendChild($projectGroupNode)				   					
								
									$item.ParentNode.ReplaceChild($item.OwnerDocument.CreateComment($item.OuterXml), $item)		   																   														   										
									$temp = "False"			   							   			
								}
							}				   
						}				   								
					}
				}
				$temp = "False"				
			}

			#Saving the modified Azure project file
			$xml.save($projectItem.FullName)					
		}				
	}
}
catch
{
	$_ | Write-Host
	Write-Warning "Failed to add import 'NuGet.targets' to $($project.Name)"
}
