require 'algolia'

# Snippet for the customDelete method.
#
# allow del method for a custom path with minimal parameters
def snippet_for_custom_delete
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.custom_delete("/test/minimal")

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the customGet method.
#
# allow get method for a custom path with minimal parameters
def snippet_for_custom_get
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.custom_get("/test/minimal")

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the customPost method.
#
# allow post method for a custom path with minimal parameters
def snippet_for_custom_post
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.custom_post("/test/minimal")

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the customPut method.
#
# allow put method for a custom path with minimal parameters
def snippet_for_custom_put
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.custom_put("/test/minimal")

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the getClusterIncidents method.
#
# getClusterIncidents
def snippet_for_get_cluster_incidents
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.get_cluster_incidents("c1-de")

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the getClusterStatus method.
#
# getClusterStatus
def snippet_for_get_cluster_status
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.get_cluster_status("c1-de")

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the getIncidents method.
#
# getIncidents
def snippet_for_get_incidents
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.get_incidents

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the getIndexingTime method.
#
# getIndexingTime
def snippet_for_get_indexing_time
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.get_indexing_time("c1-de")

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the getInventory method.
#
# getInventory
def snippet_for_get_inventory
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.get_inventory

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the getLatency method.
#
# getLatency
def snippet_for_get_latency
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.get_latency("c1-de")

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the getMetrics method.
#
# getMetrics
def snippet_for_get_metrics
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.get_metrics('avg_build_time', 'minute')

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the getReachability method.
#
# getReachability
def snippet_for_get_reachability
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.get_reachability("c1-de")

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end

# Snippet for the getStatus method.
#
# getStatus
def snippet_for_get_status
  # Initialize the client
  client = Algolia::MonitoringClient.create('YOUR_APP_ID', 'YOUR_API_KEY')

  # Call the API
  resp = client.get_status

  # use the class directly
  puts resp

  # print the JSON response
  puts resp.to_json
end