variable "namespace" {
  description = "Kubernetes namespace"
  type        = string
  default     = "cide-app"
}

variable "postgres_password" {
  description = "PostgreSQL password"
  type        = string
  sensitive   = true
  default     = "saludos_pass"
}

variable "api_image" {
  description = "API Docker image"
  type        = string
  default     = "helloworldapi:latest"
}

variable "frontend_image" {
  description = "Frontend Docker image"
  type        = string
  default     = "frontend:latest"
}
