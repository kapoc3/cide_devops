output "namespace" {
  description = "Kubernetes namespace"
  value       = kubernetes_namespace.this.metadata[0].name
}

output "api_service" {
  description = "API service endpoint"
  value       = kubernetes_service.api.spec[0].port[0].node_port
}

output "frontend_service" {
  description = "Frontend service endpoint"
  value       = kubernetes_service.frontend.spec[0].port[0].node_port
}
