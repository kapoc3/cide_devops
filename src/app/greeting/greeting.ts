import { Component, inject, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { GreetingService } from './greeting.service';
import { ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-greeting',
  imports: [CommonModule, FormsModule],
  templateUrl: './greeting.html',
  styleUrl: './greeting.css',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class Greeting {
  private greetingService = inject(GreetingService);

  name = signal('');
  greeting = signal<string>('');
  loading = signal(false);
  error = signal<string>('');

  onSubmit() {
    if (!this.name().trim()) {
      this.error.set('Por favor ingrese un nombre');
      return;
    }

    this.loading.set(true);
    this.error.set('');
    this.greeting.set('');

    this.greetingService.getGreeting(this.name().trim()).subscribe({
      next: (response) => {
        this.greeting.set(response);
        this.loading.set(false);
      },
      error: (err) => {
        this.error.set('Error al conectar con el backend');
        this.loading.set(false);
      }
    });
  }
}
