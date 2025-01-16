import React from 'react';
import type {Meta, StoryObj} from '@storybook/react';

import {HomeComponent} from './HomeComponent';

const meta: Meta<typeof HomeComponent> = {
  component: HomeComponent,
};

export default meta;

type Story = StoryObj<typeof HomeComponent>;

export const Basic: Story = {args: {}};
