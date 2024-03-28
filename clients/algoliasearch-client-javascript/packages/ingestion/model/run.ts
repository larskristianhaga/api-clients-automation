// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import type { RunOutcome } from './runOutcome';
import type { RunProgress } from './runProgress';
import type { RunReasonCode } from './runReasonCode';
import type { RunStatus } from './runStatus';
import type { RunType } from './runType';

export type Run = {
  /**
   * Universally unique identifier (UUID) of a task run.
   */
  runID: string;

  appID: string;

  /**
   * Universally unique identifier (UUID) of a task.
   */
  taskID: string;

  status: RunStatus;

  progress?: RunProgress;

  outcome?: RunOutcome;

  /**
   * Maximum accepted percentage of failures for a task run to finish successfully.
   */
  failureThreshold?: number;

  /**
   * More information about the task run\'s outcome.
   */
  reason?: string;

  reasonCode?: RunReasonCode;

  type: RunType;

  /**
   * Date of creation in RFC3339 format.
   */
  createdAt: string;

  /**
   * Date of start in RFC3339 format.
   */
  startedAt?: string;

  /**
   * Date of finish in RFC3339 format.
   */
  finishedAt?: string;
};
